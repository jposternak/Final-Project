using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    static class Evaluator
    {

        private static List<Constraint> constraints = new List<Constraint>();

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
            //day of week

            //fridays

            //clash with other blocks

            //multiple places at the same time


        }

        private static void location()
        {

            //room features


            //movement around campus & buildings & rooms


        }

        private static void history()
        {

            //previous semesters

        }
    }
}
