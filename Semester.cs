using Final_Project.grilDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_Project.grilDataSet;


namespace Final_Project
{
    [Serializable]
    public class Semester
    {
        public int Id { get; set; }
        public string HebrewYear { get; set; }
        public string SemesterType { get; set; }
        public DateTime Begda { get; set; }
        public DateTime Endda { get; set; }

        private grilDataSet grilDataSet = new Final_Project.grilDataSet();

        public static Semester getFromDatabase(int semesterID)
        {
            Semester s= new Semester();
            s.Id = semesterID;
            
            SemesterTableAdapter adapter = new SemesterTableAdapter();
            SemesterDataTable dt = adapter.GetDataByID(s.Id);

            s.HebrewYear = dt.Rows[0][1].ToString();
            s.SemesterType = dt.Rows[0][2].ToString();
            s.Begda = (DateTime)dt.Rows[0][3];
            s.Endda = (DateTime)dt.Rows[0][4];



            return s;
        }

    }
}
