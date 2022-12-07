using System.Collections.Generic;

namespace Final_Project
{
    static class Evaluator
    {

        private static List<Constraint> constraints = new List<Constraint>();

        private static List<ScheduleBlock> blocksOfMahzor = new List<ScheduleBlock>();

        private static ScheduleBlock sb { get; set; }
        private static Dictionary<Features, int> RoomFeatures { get; set; }

        public static List<Constraint> evaluate(ScheduleBlock scheduleBlock)
        {

            sb = scheduleBlock;

            //shlifa


            //eval

            return constraints;
        }

        //funkziat shlifa
        private static void getFromDB()
        {

            RoomFeatures = sb.room.getRoomFeatures();
            blocksOfMahzor = ScheduleBlock.getListbyMahzorSemester(sb.degreeClass.Id, sb.semester.Id);
            //עיתוי

            //מיקום

            //היסטוריה

        }

        private static void evaluation()
        {

            //avg or sum all constraints

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

            //room features


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
