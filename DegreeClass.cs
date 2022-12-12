using Final_Project.grilDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public Dictionary<Features, int> DCFeatures { get; set; }

        private static DegreeClassTableAdapter adapter = new DegreeClassTableAdapter();
        private static DegreeClassFeaturesTableAdapter f_adapter = new DegreeClassFeaturesTableAdapter();


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
                dc.DCFeatures = getDCFeaturesFromDB(id);
            }



            return dc;
        }

        public void uploadChanges()
        {
            adapter.UpdateQuery(this.Name, this.Degree.Id, this.NumberOfStudents, this.StartingSemester.Id,this.Duration, this.Summer,this.WeeklyHours, this.isActive, this.Id);
        }


        private static Dictionary<Features, int> getDCFeaturesFromDB(int dcID)
        {

            Dictionary<Features, int> features = new Dictionary<Features, int>();
            DataRowCollection rows = f_adapter.GetData(dcID).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int f_id = (int)rows[i][1];
                Features f = Features.GetFeatures(f_id);
                int qual = (int)rows[i][2];
                features.Add(f, qual);
            }

            return features;

        }

        //IMPLEMENT REMOVE



    }
}
