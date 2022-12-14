using System;
using System.Collections.Generic;

namespace Final_Project
{
    static class Evaluator
    {

        private static List<Constraint> constraints = new List<Constraint>();

        private static List<ScheduleBlock> blocksOfMahzor = new List<ScheduleBlock>();

        private static ScheduleBlock sb { get; set; }
        private static Dictionary<int, int> RoomFeatures = new Dictionary<int, int>();

        public static List<Constraint> evaluate(ScheduleBlock scheduleBlock)
        {

            sb = scheduleBlock;
            constraints.Clear();
            blocksOfMahzor.Clear();
            RoomFeatures.Clear();

            //shlifa
            getFromDB();

            //eval
            evaluation();

            return constraints;
        }

        //funkziat shlifa
        private static void getFromDB()
        {

            foreach (KeyValuePair<Features, int> entry in sb.room.getRoomFeatures())
            {
                // do something with entry.Value or entry.Key
                int fID = entry.Key.Id;
                int qual = entry.Value;
                RoomFeatures.Add(fID, qual);
            }
            blocksOfMahzor = ScheduleBlock.getListbyMahzorSemester(sb.degreeClass.Id, sb.semester.Id);

        }

        private static void evaluation()
        {

            //avg or sum all constraints
            timing();
            location();
            history();

        }

        private static void timing()
        {
            //day of week -> -90
            if (sb.DayOfWeek == 7)
            {
                Constraint c = new Constraint("Saturdays", sb, null, Constraint.Type.Error, 90);
                constraints.Add(c);
            }

            //fridays -> -90
            if (sb.DayOfWeek == 6 && sb.EndTime > 14.3)
            {
                Constraint c = new Constraint("Fridays - EndTime", sb, null, Constraint.Type.Error, 90);
                constraints.Add(c);
            }

            //clash with other blocks
            checkHafifa();

            //multiple places at the same time


        }

        private static void location()
        {

            Dictionary<Features, int> dcFeatures = sb.degreeClass.DCFeatures;
            Dictionary<Features, int> roomFeatures = sb.room.getRoomFeatures();

            foreach (KeyValuePair<Features, int> entry in dcFeatures)
            {
                // do something with entry.Value or entry.Key
                Features feature = entry.Key;
                int dcQual = entry.Value;
                int roomQual;
                roomFeatures.TryGetValue(feature, out roomQual);

                //קיבולת
                if (feature.Id == 2)
                {
                    checkCapacity(roomQual, dcQual, feature);
                }

                


            }

            //movement around campus & buildings & rooms
            checkMovement();



        }

        private static void checkHafifa()
        {

            List<ScheduleBlock> blocksInRoom = ScheduleBlock.getListbyRoom(sb.room.Id, sb.semester.Id);

            //iterate all blocks in room and find 
            foreach (ScheduleBlock currBlock in blocksInRoom)
            {

                //only if same day & not same block
                if (currBlock.DayOfWeek == sb.DayOfWeek && currBlock.Id != sb.Id)
                {

                    if (currBlock.StartTime < sb.StartTime && currBlock.EndTime > sb.StartTime)
                    {
                        Constraint c = new Constraint("ההקצאה חופפת עם הקצאה אחרת", sb, null, Constraint.Type.Error, 90);
                        constraints.Add(c);
                    }else if(currBlock.StartTime > sb.StartTime && currBlock.EndTime < sb.EndTime)
                    {
                        Constraint c = new Constraint("ההקצאה חופפת עם הקצאה אחרת", sb, null, Constraint.Type.Error, 90);
                        constraints.Add(c);
                    }else if (currBlock.StartTime > sb.StartTime && currBlock.StartTime < sb.EndTime && currBlock.EndTime > sb.EndTime)
                    {
                        Constraint c = new Constraint("ההקצאה חופפת עם הקצאה אחרת", sb, null, Constraint.Type.Error, 90);
                        constraints.Add(c);
                    }else if (currBlock.EndTime <= sb.StartTime || currBlock.StartTime >= sb.EndTime)
                    {
                        Double mervahEnd = Math.Abs(currBlock.EndTime - sb.StartTime);
                        Double mervahStart = Math.Abs(currBlock.StartTime - sb.EndTime);
                        Double minMerhav = Math.Min(mervahEnd, mervahStart);

                        ScheduleBlock currBlockOnline = ScheduleBlock.getFromDB(currBlock.Id);
                        //diferent mahzor
                        if (currBlockOnline.degreeClass.Id != sb.degreeClass.Id && minMerhav <= 0.15)
                        {
                            Constraint c = new Constraint("אין מספיק זמן בין תארים", sb, null, Constraint.Type.Warning, 30);
                            constraints.Add(c);
                        }
                    }

                    
                }



            }

        }

        private static void checkCapacity(int roomCapacity, int numberOfStudents, Features f)
        {

            double penalty = (1.0 * numberOfStudents) / roomCapacity;
            if (penalty > 1)
            {
                Constraint c = new Constraint("Exceeded Capacity", sb, f, Constraint.Type.Error, penalty * 100);
                constraints.Add(c);
            }
            else if (penalty > 0.80)
            {
                Constraint c = new Constraint("Almost Full Capacity", sb, f, Constraint.Type.Warning, penalty * 100);
                constraints.Add(c);
            }
            else if (penalty < 0.40)
            {
                Constraint c = new Constraint("Almost Empty", sb, f, Constraint.Type.Warning, 100 - penalty * 100);
                constraints.Add(c);
            }
            else
            {
                Constraint c = new Constraint("Good", sb, f, Constraint.Type.OK, 100 - penalty * 100);
                constraints.Add(c);
            }
        }

        private static void checkMovement()
        {
            foreach (ScheduleBlock mSB in blocksOfMahzor)
            {


                //Campus -> -90
                if (sb.room.building.Campus.Name != mSB.campusName)
                {
                    Constraint c = new Constraint("Campus Movement", sb, null, Constraint.Type.Error, 90);
                    constraints.Add(c);
                }
                else
                {

                    //Building
                    if (sb.room.building.Name != mSB.buildingName && sb.DayOfWeek == mSB.DayOfWeek)
                    {

                        //maybe check also time???
                        Constraint c = new Constraint("Same day - Different Buildings", sb, null, Constraint.Type.Warning, 60);
                        constraints.Add(c);
                    }
                    else
                    {
                        //Room
                        if (sb.room.Id != mSB.roomID && sb.DayOfWeek == mSB.DayOfWeek)
                        {

                            //maybe check also time???
                            Constraint c = new Constraint("Same day & Building - Different Rooms", sb, null, Constraint.Type.Warning, 30);
                            constraints.Add(c);
                        }

                    }

                }

            }

        }
        private static void history()
        {

            //previous semesters

        }
    }
}
