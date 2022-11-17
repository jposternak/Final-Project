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
    public class DegreeClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Degree Degree { get; set; }
        public int NumberOfStudents { get; set; }
        public Semester StartingSemester { get; set; }  
        public int Duration { get; set; }
        public bool Summer { get; set; }
        public int WeeklyHours { get; set; }


        public static DegreeClass getFromDatabase(int id)
        {
            DegreeClass dc = new DegreeClass();
            dc.Id = id;

            DegreeClassTableAdapter adapter = new DegreeClassTableAdapter();
            DegreeClassDataTable dt = adapter.GetDataByDCID(dc.Id);

            dc.Name = dt.Rows[0][1].ToString();
            dc.Degree = Degree.getFromDatabase((int)dt.Rows[0][2]);
            dc.NumberOfStudents = (int)dt.Rows[0][3];
            dc.StartingSemester = Semester.getFromDatabase((int)dt.Rows[0][4]);
            dc.Duration = (int)dt.Rows[0][5];
            dc.Summer = (Boolean)dt.Rows[0][6];
            dc.WeeklyHours = (int)dt.Rows[0][7];

            return dc;
        }



    }
}
