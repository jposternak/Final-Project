using System.Collections;
using System.Collections.Generic;
using System.Windows.Interop;

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

            //RoomFeatures = sb.room.getRoomFeatures();

            foreach (KeyValuePair<Features, int> entry in sb.room.getRoomFeatures())
            {
                // do something with entry.Value or entry.Key
                int fID = entry.Key.Id;
                int qual = entry.Value;
                RoomFeatures.Add(fID, qual);
            }
            blocksOfMahzor = ScheduleBlock.getListbyMahzorSemester(sb.degreeClass.Id, sb.semester.Id);
            //עיתוי

            //מיקום

            //היסטוריה

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

            //multiple places at the same time


        }

        private static void location()
        {

            //room features -> capacity
            

            Features capacityFeature = Features.GetFeatures(2);
            if (RoomFeatures.ContainsKey(2))
            {
                int capacity = RoomFeatures[2];
                //RoomFeatures.TryGetValue(capacityFeature, out capacity);
                double penalty = (1.0 * sb.degreeClass.NumberOfStudents) / capacity;

                if (penalty > 1)
                {
                    Constraint c = new Constraint("Exceeded Capacity", sb, capacityFeature, Constraint.Type.Error, penalty * 100);
                    constraints.Add(c);
                }
                else if (penalty > 0.80)
                {
                    Constraint c = new Constraint("Almost Full Capacity", sb, capacityFeature, Constraint.Type.Warning, penalty * 100);
                    constraints.Add(c);
                }
                else if (penalty < 0.40)
                {
                    Constraint c = new Constraint("Almost Empty", sb, capacityFeature, Constraint.Type.Warning, 100 - penalty * 100);
                    constraints.Add(c);
                }
                else
                {
                    Constraint c = new Constraint("Good", sb, capacityFeature, Constraint.Type.OK, 100 - penalty * 100);
                    constraints.Add(c);
                }
            }
            //movement around campus & buildings & rooms
            foreach (ScheduleBlock mSB in blocksOfMahzor)
            {


                //Campus -> -90
                if (sb.room.building.Campus.Name != mSB.campusName)
                {
                    Constraint c = new Constraint("Campus Movement", sb, null, Constraint.Type.Error, 90);
                    constraints.Add(c);
                }
                else {
                    
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
