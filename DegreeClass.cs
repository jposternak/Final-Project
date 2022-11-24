using Final_Project.grilDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_Project.grilDataSet;

namespace Final_Project
{
    [Serializable]
    public class DegreeClass
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public Degree Degree { get; set; }
        public int NumberOfStudents { get; set; }
        public Semester StartingSemester { get; set; }  
        public int Duration { get; set; }
        public bool Summer { get; set; }
        public int WeeklyHours { get; set; }
        public bool isActive { get; set; }

        private static DegreeClassTableAdapter adapter = new DegreeClassTableAdapter();


        public static void create(string name, Degree degree, int numberOfStudents,
            Semester semester, int duration, bool summer, int weeklyHours, bool isActive)
        {
            adapter.InsertQuery(name, degree.Id, numberOfStudents, semester.Id, duration, summer, weeklyHours, isActive);
        }


        public static DegreeClass getFromDatabase(int id)
        {
            DegreeClass dc = new DegreeClass();
            dc.Id = id;
            DataRowCollection rows = adapter.GetDataByDCID(id).Rows;

            if(rows.Count != 0)
            {
                dc.Name = rows[0][1].ToString();
                dc.Degree = Degree.getFromDatabase((int)rows[0][2]);
                dc.NumberOfStudents = (int)rows[0][3];
                dc.StartingSemester = Semester.getFromDatabase((int)rows[0][4]);
                dc.Duration = (int)rows[0][5];
                dc.Summer = (Boolean)rows[0][6];
                dc.WeeklyHours = (int)rows[0][7];
                dc.isActive = (Boolean)rows[0][10];
            }



            return dc;
        }

        public void uploadChanges()
        {
            adapter.UpdateQuery(this.Name, this.Degree.Id, this.NumberOfStudents, this.StartingSemester.Id,this.Duration, this.Summer,this.WeeklyHours, this.isActive, this.Id);
        }


        //IMPLEMENT REMOVE



    }
}
