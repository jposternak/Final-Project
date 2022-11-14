using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
    [Serializable]
    public class ScheduleBlock
    {
        public int Id { get; set; }
        public int DayOfWeek { get; set; }
        
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        TimeSpan StartTimeT { get; set; }
        TimeSpan EndTimeT { get; set; }

        public int roomID { get; set; }
        public String roomName { get; set; }
        public int roomFloor { get; set; }
        public String buildingName { get; set; }
        public String campusName { get; set; }


        public String DegreeClassName { get; set; }
        public String FacultyName { get; set; }

        public ScheduleBlock(int Id, int DayOfWeek, TimeSpan StartTime, TimeSpan EndTime)
        {
            this.Id = Id;
            this.DayOfWeek = DayOfWeek;
            this.StartTime = StartTime.Hours + StartTime.Minutes/100.0;
            this.StartTimeT = StartTime;
            this.EndTime = EndTime.Hours + EndTime.Minutes / 100.0;
            this.EndTimeT = EndTime;
        }


        public String TimeToString()
        {
            String s = "";
            String StartHour_str = StartTime.ToString();
            double decimalTime = StartTime - Math.Truncate(StartTime);
            if (decimalTime == 0) StartHour_str += ".00";      

            s += $"({StartTimeT.ToString()}-{EndTimeT.ToString()})\n";

            return s;
        }


        public override String ToString()
        {
            String s = "";
            String StartHour_str = StartTime.ToString();
            double decimalTime = StartTime - Math.Truncate(StartTime);
            if (decimalTime == 0) StartHour_str += ".00";



            // s += $"({StartHour_str})\n";         

            s += $"({StartTimeT.ToString()}-{EndTimeT.ToString()})\n";
            
            s += $"{DegreeClassName}";

            return s;
        }

    }
}
