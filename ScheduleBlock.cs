using Final_Project.grilDataSetTableAdapters;
using Final_Project.grilDataViewsSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

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

        public Semester semester { get; set; }


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

        public static void saveToDB(int day, DateTime startTime, int roomID, int DegreeClassID, int semesterID)
        {
            String time = $"{startTime.Hour:00}:{startTime.Minute:00}:{startTime.Second:00}";
            ScheduleBlockTableAdapter scheduleBlockTableAdapter = new ScheduleBlockTableAdapter();
            scheduleBlockTableAdapter.InsertQuery(day, time, roomID, DegreeClassID,semesterID);
        }

        public static Boolean deleteFromDB(int blockID)
        {
            try
            {
                ScheduleBlockTableAdapter scheduleBlockTableAdapter = new ScheduleBlockTableAdapter();
                scheduleBlockTableAdapter.DeleteQuery(blockID);
                return true;
            }
            catch(Exception ex1)
            {
                MessageBox.Show("לא ניתן למחוק בלוק זה");
            }

            return false;

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


        public String RoomAndTime()
        {
            String s = "";
            String StartHour_str = StartTime.ToString();
            double decimalTime = StartTime - Math.Truncate(StartTime);
            if (decimalTime == 0) StartHour_str += ".00";

            s += $"({StartTimeT.ToString()}-{EndTimeT.ToString()})\n";

            s += $"{campusName}\t{buildingName}\n{roomName}";

            return s;
        }

        public override String ToString()
        {
            String s = "";
            String StartHour_str = StartTime.ToString();
            double decimalTime = StartTime - Math.Truncate(StartTime);
            if (decimalTime == 0) StartHour_str += ".00";
      

            s += $"({StartTimeT.ToString()}-{EndTimeT.ToString()})\n";
            
            s += $"{DegreeClassName}";

            return s;
        }

        public static List<ScheduleBlock> getListbyRoom(int RoomID)
        {
            List<ScheduleBlock> list = new List<ScheduleBlock>();

            ScheduleBlockDetailsTableAdapter adapter = new ScheduleBlockDetailsTableAdapter();
            DataRowCollection rows = adapter.GetDataByRoomID(RoomID).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int id = (int)rows[i][0];
                int dayOfWeek = (int)rows[i][1];
                TimeSpan begda = (TimeSpan)rows[i][2];
                TimeSpan endda = (TimeSpan)rows[i][3];

                ScheduleBlock sb = new ScheduleBlock(id, dayOfWeek, begda, endda);
                sb.roomID = (int)rows[i][4];
                sb.roomName = (String)rows[i][5];
                sb.roomFloor = (int)rows[i][6];
                sb.buildingName = (String)rows[i][7];
                sb.campusName = (String)rows[i][8];
                sb.DegreeClassName = (String)(rows[i][9]);
                sb.FacultyName = (String)(rows[i][10]);

                list.Add(sb);

            }

            return list;

        }

        public static List<ScheduleBlock> getListbyMahzorSemester(int mahzor, int semester)
        {
            List<ScheduleBlock> list = new List<ScheduleBlock>();

            ScheduleBlockDetailsTableAdapter adapter = new ScheduleBlockDetailsTableAdapter();
            DataRowCollection rows = adapter.GetDataByMahzor(mahzor,semester).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int id = (int)rows[i][0];
                int dayOfWeek = (int)rows[i][1];
                TimeSpan begda = (TimeSpan)rows[i][2];
                TimeSpan endda = (TimeSpan)rows[i][3];

                ScheduleBlock sb = new ScheduleBlock(id, dayOfWeek, begda, endda);
                sb.roomID = (int)rows[i][4];
                sb.roomName = (String)rows[i][5];
                sb.roomFloor = (int)rows[i][6];
                sb.buildingName = (String)rows[i][7];
                sb.campusName = (String)rows[i][8];
                sb.DegreeClassName = (String)(rows[i][9]);
                sb.FacultyName = (String)(rows[i][10]);

                list.Add(sb);

            }

            return list;

        }

    }
}
