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
    public class Degree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FacultyID { get; set; }

        static public Degree getFromDatabase(int id)
        {
            Degree d = new Degree();
            d.Id = id;

            DegreeTableAdapter adapter = new DegreeTableAdapter();
            DegreeDataTable dt = adapter.GetDataByID(d.Id);

            d.Name = dt.Rows[0][1].ToString();
            d.FacultyID = (int)dt.Rows[0][2];

            return d;
        }

    }
}
