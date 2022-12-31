using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Final_Project
{
    static class Evaluator
    {

        private static ScheduleBlock sb { get; set; }

        private static List<Constraint> constraints = new List<Constraint>();
        private static List<ScheduleBlock> blocksOfMahzor = new List<ScheduleBlock>();
        private static Dictionary<int, int> RoomFeatures = new Dictionary<int, int>();

        public static List<Constraint> evaluate(ScheduleBlock scheduleBlock)
        {

            sb = scheduleBlock;
            constraints.Clear();
            blocksOfMahzor.Clear();
            RoomFeatures.Clear();

            //shlifa
            getFromDB(sb.DayOfWeek);

            //eval
            evaluation();

            return constraints.Distinct().ToList();
        }

        public static Boolean isSimultaneous(ScheduleBlock scheduleBlock)
        {

            sb = scheduleBlock;
            constraints.Clear();
            blocksOfMahzor.Clear();
            RoomFeatures.Clear();

            getFromDB(sb.DayOfWeek);

            return !checkMultiplace();
        }

        //funkziat shlifa
        private static void getFromDB(int dayOfWeek)
        {
            //Room Features
            foreach (KeyValuePair<Features, int> entry in sb.room.getRoomFeatures())
            {
                // do something with entry.Value or entry.Key
                int fID = entry.Key.Id;
                int qual = entry.Value;
                RoomFeatures.Add(fID, qual);
            }

            //All Blocks of Mahzor
            blocksOfMahzor = ScheduleBlock.getListbyMahzorSemester(sb.degreeClass.Id, sb.semester.Id, dayOfWeek);

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
                Constraint c = new Constraint(Constraint.Type.Timing_Saturday, sb, null, Constraint.Severity.Error, 90);
                c.Comment = "לא ניתן לשבץ ביום שבת";
                constraints.Add(c);
            }

            //fridays -> -90
            if (sb.DayOfWeek == 6 && sb.EndTime > 14.3)
            {
                Constraint c = new Constraint(Constraint.Type.Timing_Friday, sb, null, Constraint.Severity.Error, 90);
                c.Comment = "לא ניתן לשבץ ביום שישי אחרי השעה 14:30";
                constraints.Add(c);
            }

            //clash with other blocks
            checkHafifa();


            //multiple places at the same time
            checkMultiplace();

        }


        private static Boolean checkMultiplace()
        {
            //ind. pitzul?
            List<ScheduleBlock> blocksOfMahzor_ext = blocksOfMahzor;
            blocksOfMahzor_ext.Add(sb);

            //look for same times, in different place
            foreach (ScheduleBlock SB_1 in blocksOfMahzor_ext)
            {
                List<ScheduleBlock> blocksOfMahzor_int = new List<ScheduleBlock>();
                blocksOfMahzor_int.AddRange(blocksOfMahzor);
                blocksOfMahzor_int.Remove(SB_1);

                foreach (ScheduleBlock SB_2 in blocksOfMahzor_int)
                {
                    if (SB_1.Id != SB_2.Id)
                    {
                        //Check Same day
                        if (SB_1.DayOfWeek == SB_2.DayOfWeek)
                        {
                            if (SB_1.roomID != SB_2.roomID && isOverlap(SB_1, SB_2))
                            {
                                //same class, different places ->Simultaneous
                                Constraint c = new Constraint(Constraint.Type.Simultaneous, sb, null, Constraint.Severity.Error, 90);
                                c.Comment = $"מחזור זה משובץ בשני מקומות בו זמנית - {SB_1.ToText()} & {SB_2.ToText()}";
                                constraints.Add(c);
                                return false;
                            }

                        }
                    }
                }
            }

            return true;

        }

        private static Boolean isOverlap(ScheduleBlock SB_1, ScheduleBlock SB_2)
        {
            Boolean hafifa = false;
            if (SB_1.Id != SB_2.Id && SB_1.DayOfWeek == SB_2.DayOfWeek)
            {
                Boolean before = (SB_2.EndTime < SB_1.StartTime && SB_2.StartTime < SB_1.StartTime);
                Boolean partialStart = (SB_2.StartTime < SB_1.StartTime && SB_2.EndTime > SB_1.StartTime);
                Boolean completeHafifa = (SB_2.StartTime >= SB_1.StartTime && SB_2.EndTime <= SB_1.EndTime);
                Boolean partialEnd = (SB_2.StartTime < SB_1.EndTime && SB_2.EndTime > SB_1.EndTime);
                Boolean after = (SB_2.StartTime > SB_1.EndTime && SB_2.EndTime > SB_1.EndTime);
                Boolean across = (SB_2.StartTime < SB_1.StartTime && SB_2.EndTime > SB_1.EndTime);

                hafifa = partialStart || completeHafifa || partialEnd || across;
            }
            return hafifa;
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

        //Hafifa in same ClassRoom ---> Overlap
        private static void checkHafifa()
        {

            List<ScheduleBlock> blocksInRoom = ScheduleBlock.getListbyRoom(sb.room.Id, sb.semester.Id, sb.DayOfWeek);

            //iterate all blocks in room and find 
            foreach (ScheduleBlock currBlock in blocksInRoom)
            {

                //only if same day & not same block
                if (isOverlap(currBlock, sb))
                {
                    Constraint c = new Constraint(Constraint.Type.Overlap, sb, null, Constraint.Severity.Error, 90);
                    c.Comment = $"בחדר זה יש חפיפה בין הקצאות - {currBlock.ToText()} & {sb.ToText()}";
                    constraints.Add(c);

                }

                //If not, then check for Spacing between Mahzorim
                else if (currBlock.EndTime <= sb.StartTime || currBlock.StartTime >= sb.EndTime)
                {
                    Double mervahEnd = Math.Abs(currBlock.EndTime - sb.StartTime);
                    Double mervahStart = Math.Abs(currBlock.StartTime - sb.EndTime);
                    Double minMerhav = Math.Min(mervahEnd, mervahStart);

                    ScheduleBlock currBlockOnline = ScheduleBlock.getFromDB(currBlock.Id);
                    //diferent mahzor
                    if (currBlockOnline.degreeClass.Id != sb.degreeClass.Id && minMerhav <= 0.15)
                    {
                        // ====> Spacing
                        Constraint c = new Constraint(Constraint.Type.Spacing, sb, null, Constraint.Severity.Warning, 30);
                        c.Comment = $"מרווח הזמן בין מחזורים קטן מ-15 דקות  -  {currBlock.ToText()} & {sb.ToText()}";
                        constraints.Add(c);
                    }
                }


            }



        }



        private static void checkCapacity(int roomCapacity, int numberOfStudents, Features f)
        {

            double penalty = (1.0 * numberOfStudents) / roomCapacity;
            if (penalty > 1)
            {
                //Constraint c = new Constraint("Exceeded Capacity", sb, f, Constraint.Severity.Error, penalty * 100);
                Constraint c = new Constraint(Constraint.Type.Capacity, sb, f, Constraint.Severity.Error, penalty * 100);
                c.Comment = $"קיבולת החדר לא מספיקה";
                constraints.Add(c);
            }
            else if (penalty > 0.80)
            {
                //Constraint c = new Constraint("Almost Full Capacity", sb, f, Constraint.Severity.Warning, penalty * 100);
                Constraint c = new Constraint(Constraint.Type.Capacity, sb, f, Constraint.Severity.Warning, penalty * 100);
                c.Comment = $"חדר כמעט מלא - {penalty * 100}%";
                constraints.Add(c);
            }
            else if (penalty < 0.40)
            {
                //Constraint c = new Constraint("Almost Empty", sb, f, Constraint.Severity.Warning, 100 - penalty * 100);
                Constraint c = new Constraint(Constraint.Type.Capacity, sb, f, Constraint.Severity.Warning, 100 - penalty * 100);
                c.Comment = $"חדר כמעט ריק - {100 - penalty * 100}%";
                constraints.Add(c);
            }
            else
            {
                //Constraint c = new Constraint("Good", sb, f, Constraint.Severity.OK, 100 - penalty * 100);
                Constraint c = new Constraint(Constraint.Type.Capacity, sb, f, Constraint.Severity.OK, 100 - penalty * 100);
                c.Comment = $"ניצול מיטבי - {100 - penalty * 100}%";
                constraints.Add(c);
            }
        }

        private static void checkMovement()
        {
            List<ScheduleBlock> blocksOfMahzor_int = blocksOfMahzor;
            blocksOfMahzor_int.Remove(sb);
            foreach (ScheduleBlock mSB in blocksOfMahzor_int)
            {


                //Campus -> -90
                if (sb.room.building.Campus.Name != mSB.campusName)
                {
                    //"Campus Movement"
                    Constraint c = new Constraint(Constraint.Type.Movement, sb, null, Constraint.Severity.Error, 90);
                    c.Comment = $"הקצאה זו גורמת לתזוזה בין קמפוסים שונים";
                    constraints.Add(c);
                }
                else
                {

                    //Building
                    if (sb.room.building.Name != mSB.buildingName && sb.DayOfWeek == mSB.DayOfWeek)
                    {

                        //maybe check also time???
                        //"Same day - Different Buildings"
                        Constraint c = new Constraint(Constraint.Type.Movement, sb, null, Constraint.Severity.Warning, 60);
                        c.Comment = $"הקצאה זו גורמת לתזוזה בין בניינים שונים";
                        constraints.Add(c);
                    }
                    else
                    {
                        //Room
                        if (sb.room.Id != mSB.roomID && sb.DayOfWeek == mSB.DayOfWeek)
                        {

                            //maybe check also time???
                            //"Same day & Building - Different Rooms"
                            Constraint c = new Constraint(Constraint.Type.Movement, sb, null, Constraint.Severity.Warning, 30);
                            c.Comment = $"הקצאה זו גורמת לתזוזה בין חדרים שונים";
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
