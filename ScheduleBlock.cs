using Final_Project.grilDataSetTableAdapters;
using Final_Project.grilDataViewsSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Semester semester { get; set; }
        public DegreeClass degreeClass { get; set; }
        public String comments { get; private set; }

        public bool isOffline { get; private set; }

        public int roomID { get; private set; }
        public String roomName { get; private set; }
        public int roomFloor { get; private set; }
        public String buildingName { get; private set; }
        public String campusName { get; private set; }
        public String DegreeClassName { get; private set; }
        public String FacultyName { get; private set; }

        private static ScheduleBlockTableAdapter adapter = new ScheduleBlockTableAdapter();
        private static ScheduleBlockDetailsTableAdapter detailsAdapter = new ScheduleBlockDetailsTableAdapter();

        private ScheduleBlock()
        {

        }

        public ScheduleBlock(int Id, int DayOfWeek, TimeSpan StartTime)
        {
            this.Id = Id;
            this.DayOfWeek = DayOfWeek;
            this.setStartTime(StartTime);
            this.isOffline = true;
        }

        private void setStartTime(TimeSpan StartTime)
        {
            this.StartTimeT = StartTime;
            this.StartTime = StartTimeT.Hours + StartTimeT.Minutes / 100.0;
            this.EndTimeT = StartTimeT.Add(TimeSpan.FromMinutes(45));
            this.EndTime = EndTimeT.Hours + EndTimeT.Minutes / 100.0;
        }

        public void setStartTime(TimeSpan StartTime, int numberOfBlocks)
        {
            this.StartTimeT = StartTime;
            this.StartTime = StartTimeT.Hours + StartTimeT.Minutes / 100.0;
            this.EndTimeT = StartTimeT.Add(TimeSpan.FromMinutes(45* numberOfBlocks));
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

            if (!this.isOffline)
            {

                this.uploadChanges();
            }

        }

        public void updateComments(String comments)
        {
            if (!this.isOffline)
            {
                this.comments = comments;
                this.uploadChanges();
            }
        }

        private void uploadChanges()
        {
            String time = $"{this.StartTimeT.Hours:00}:{this.StartTimeT.Minutes:00}:{this.StartTimeT.Seconds:00}";
            adapter.UpdateQuery(this.DayOfWeek, time, this.room.Id, this.degreeClass.Id, this.semester.Id,this.comments, this.Id);
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
                //var comm_db = rows[0][6];
                String comm = "";
                if (rows[0][6].GetType() != typeof(System.DBNull))
                {
                    comm = (String)rows[0][6];
                }

                sb.Id = scheduleBlockID;
                sb.DayOfWeek = dayOfWeek;
                sb.setStartTime(startTime);
                sb.room = r;
                sb.degreeClass = dc;
                sb.semester = sem;
                sb.comments = comm;

                sb.isOffline = false;

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
            s += roomName;
            return s;
        }

        //done
        public String ToText()
        {

            String s = RoomAndTime();
            s += $"\n{DegreeClassName}";
            return s;


        }

        //
        public String ToOfflineText()
        {
            /*
            String s = TimeToString();
            s += $"{DegreeClassName}";
            //s += $"\n{degreeClass.Name}";
            return s;
            */
            return DegreeClassName;

        }

        //done
        private static List<ScheduleBlock> list = new List<ScheduleBlock>();
        public static List<ScheduleBlock> getListbyRoom(int RoomID, int SemesterID,int dayOfweek)
        {
            list = new List<ScheduleBlock>();

            ScheduleBlockDetailsTableAdapter sbd = new ScheduleBlockDetailsTableAdapter();
            DataRowCollection rows = sbd.GetDataByRoomIDSemester(RoomID, SemesterID, dayOfweek).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                
                int id = (int)rows[i][0];
                int dayOfWeek = (int)rows[i][1];
                TimeSpan startTime = (TimeSpan)rows[i][2];
                ScheduleBlock block = new ScheduleBlock(id, dayOfWeek, startTime);

                block.roomID = (int)rows[i][4];
                block.roomName = rows[i][5].ToString();
                block.roomFloor = (int) rows[i][6];
                block.buildingName = rows[i][7].ToString();
                block.campusName = rows[i][8].ToString();
                block.DegreeClassName = rows[i][9].ToString();
                block.FacultyName = rows[i][10].ToString();
                list.Add(block);

            }

            return list;

        }

        private static List<ScheduleBlock> list_all_days = new List<ScheduleBlock>();
        public static List<ScheduleBlock> getListbyRoom(int RoomID, int SemesterID)
        {
            list_all_days = new List<ScheduleBlock>();
            for (int i = 0; i < 7; i++)
            {
                list_all_days.AddRange(getListbyRoom(RoomID, SemesterID, i));
            }
            return list_all_days;
        }




            public static List<ScheduleBlock> getListbyMahzorSemester(int MahzorID, int SemesterID)
        {

            list = new List<ScheduleBlock>();

            ScheduleBlockDetailsTableAdapter sbd = new ScheduleBlockDetailsTableAdapter();
            DataRowCollection rows = sbd.GetDataByMahzor(MahzorID, SemesterID).Rows;

            for (int i = 0; i < rows.Count; i++)
            {

                int id = (int)rows[i][0];
                int dayOfWeek = (int)rows[i][1];
                TimeSpan startTime = (TimeSpan)rows[i][2];
                ScheduleBlock block = new ScheduleBlock(id, dayOfWeek, startTime);

                block.roomID = (int)rows[i][4];
                block.roomName = rows[i][5].ToString();
                block.roomFloor = (int)rows[i][6];
                block.buildingName = rows[i][7].ToString();
                block.campusName = rows[i][8].ToString();
                block.DegreeClassName = rows[i][9].ToString();
                block.FacultyName = rows[i][10].ToString();
                list.Add(block);

            }

            return list;

        }

        public static List<ScheduleBlock> getListbyMahzorSemester(int MahzorID, int SemesterID, int DayOfWeek)
        {

            list = new List<ScheduleBlock>();

            ScheduleBlockDetailsTableAdapter sbd = new ScheduleBlockDetailsTableAdapter();
            DataRowCollection rows = sbd.GetDataByMahzorAndDay(MahzorID, SemesterID,DayOfWeek).Rows;

            for (int i = 0; i < rows.Count; i++)
            {

                int id = (int)rows[i][0];
                int dayOfWeek = (int)rows[i][1];
                TimeSpan startTime = (TimeSpan)rows[i][2];
                ScheduleBlock block = new ScheduleBlock(id, dayOfWeek, startTime);

                block.roomID = (int)rows[i][4];
                block.roomName = rows[i][5].ToString();
                block.roomFloor = (int)rows[i][6];
                block.buildingName = rows[i][7].ToString();
                block.campusName = rows[i][8].ToString();
                block.DegreeClassName = rows[i][9].ToString();
                block.FacultyName = rows[i][10].ToString();
                list.Add(block);

            }

            return list;

        }


    }
}
