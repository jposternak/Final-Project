using Final_Project.grilDataSetTableAdapters;
using Final_Project.grilDataViewsSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using MessageBox = System.Windows.MessageBox;

namespace Final_Project
{
    [Serializable]
    public class ScheduleBlock
    {
        public int Id { get; private set; }
        public int DayOfWeek { get; set; }

        public double StartTime { get; private set; }
        public double EndTime { get; private set; }

        public TimeSpan StartTimeT { get; private set; }

        public TimeSpan EndTimeT { get; private set; }

        public Room room { get; set; }

        //public int roomID { get; set; }
        //public String roomName { get; set; }
        //public int roomFloor { get; set; }
        //public String buildingName { get; set; }
        //public String campusName { get; set; }

        public Semester semester { get; set; }

        public DegreeClass degreeClass { get; set; }

        //public String DegreeClassName { get; set; }
        //public String FacultyName { get; set; }


        private static ScheduleBlockTableAdapter adapter = new ScheduleBlockTableAdapter();
        private static ScheduleBlockDetailsTableAdapter detailsAdapter = new ScheduleBlockDetailsTableAdapter();

        public ScheduleBlock()
        {

        }

        /*
        public ScheduleBlock(int Id, int DayOfWeek, TimeSpan StartTime, TimeSpan EndTime)
        {
            this.Id = Id;
            this.DayOfWeek = DayOfWeek;
            this.StartTime = StartTime.Hours + StartTime.Minutes/100.0;
            this.StartTimeT = StartTime;
            this.EndTime = EndTime.Hours + EndTime.Minutes / 100.0;
            this.EndTimeT = EndTime;
        }
        */

        private void setStartTime(TimeSpan StartTime)
        {
            this.StartTimeT = StartTime;
            this.StartTime = StartTimeT.Hours + StartTimeT.Minutes / 100.0;
            this.EndTimeT = StartTimeT.Add(TimeSpan.FromMinutes(45));
            this.EndTime = EndTimeT.Hours + EndTimeT.Minutes / 100.0;
        }

        //done
        public static void insertNew(int day, DateTime startTime, int roomID, int DegreeClassID, int semesterID)
        {
            String time = $"{startTime.Hour:00}:{startTime.Minute:00}:{startTime.Second:00}";
            adapter.InsertQuery(day, time, roomID, DegreeClassID, semesterID);
        }

        //done
        public void changeProperties(int dayOfWeek, DateTime startTime, int roomID, int dcID, int semesterID)
        {
            this.DayOfWeek = dayOfWeek;

            TimeSpan ts = new TimeSpan();
            ts += TimeSpan.FromMinutes(startTime.Minute);
            ts += TimeSpan.FromHours(startTime.Hour);
            this.setStartTime(ts);

            this.room = Room.GetRoom(roomID);
            this.degreeClass = DegreeClass.getFromDatabase(dcID);
            this.semester = Semester.getFromDatabase(semesterID);

            this.uploadChanges();
        }

        private void uploadChanges()
        {
            String time = $"{this.StartTimeT.Hours:00}:{this.StartTimeT.Minutes:00}:{this.StartTimeT.Seconds:00}";
            adapter.UpdateQuery(this.DayOfWeek, time, this.room.Id, this.degreeClass.Id, this.semester.Id,this.Id);
        }

        //done
        public static Boolean deleteFromDB(int blockID)
        {
            try
            {
                adapter.DeleteQuery(blockID);
                return true;
            }
            catch (Exception ex1)
            {
                MessageBox.Show("לא ניתן למחוק בלוק זה");
            }
            return false;
        }

        //done
        public static ScheduleBlock getFromDB(int scheduleBlockID)
        {
            ScheduleBlock sb = new ScheduleBlock();
            DataRowCollection rows = adapter.GetDataByID(scheduleBlockID).Rows;

            if (rows.Count != 0)
            {
                int dayOfWeek = (int)rows[0][1];
                TimeSpan startTime = (TimeSpan)rows[0][2];
                int roomID = (int)rows[0][3];
                Room r = Room.GetRoom(roomID);
                int dcID = (int)rows[0][4];
                DegreeClass dc = DegreeClass.getFromDatabase(dcID);
                int semID = (int)rows[0][5];
                Semester sem = Semester.getFromDatabase(semID);

                sb.Id = scheduleBlockID;
                sb.DayOfWeek = dayOfWeek;
                //sb.StartTimeT = startTime;
                sb.setStartTime(startTime);
                sb.room = r;
                sb.degreeClass = dc;
                sb.semester = sem;
                return sb;
            }
            else return null;

        }

        //done
        public String TimeToString()
        {
            String s = "";

            String StartHour_str = StartTime.ToString();
            double decimalTime = StartTime - Math.Truncate(StartTime);
            if (decimalTime == 0) StartHour_str += ".00";

            s += $"({StartTimeT.ToString()}-{EndTimeT.ToString()})\n";

            return s;
        }

        //done
        public String RoomAndTime()
        {
            String s = TimeToString();
            s += room.ToString();
            return s;
        }

        //done
        public String ToText()
        {

            String s = RoomAndTime();
            s += $"\n{DegreeClassName}";
            return s;


        }

        //done
        public static List<ScheduleBlock> getListbyRoom(int RoomID, int SemesterID)
        {
            List<ScheduleBlock> list = new List<ScheduleBlock>();
            DataRowCollection rows = adapter.GetDataByRoomSemester(SemesterID, RoomID).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int id = (int)rows[i][0];
                ScheduleBlock block = ScheduleBlock.getFromDB(id);
                list.Add(block);
            }

            return list;

        }

        public static List<ScheduleBlock> getListbyMahzorSemester(int MahzorID, int SemesterID)
        {

            List<ScheduleBlock> list = new List<ScheduleBlock>();
            DataRowCollection rows = detailsAdapter.GetDataByMahzor(MahzorID, SemesterID).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int id = (int)rows[i][0];
                ScheduleBlock block = ScheduleBlock.getFromDB(id);
                list.Add(block);
            }

            return list;

        }

    }
}
