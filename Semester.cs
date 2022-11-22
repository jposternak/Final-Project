using Final_Project.grilDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private static SemesterTableAdapter adapter = new SemesterTableAdapter();

        public static Semester getFromDatabase(int semesterID)
        {
            Semester s= new Semester();
            s.Id = semesterID;

            DataRowCollection rows = adapter.GetDataByID(s.Id).Rows;

            if (rows.Count != 0)
            {
                s.HebrewYear = rows[0][1].ToString();
                s.SemesterType = rows[0][2].ToString();
                s.Begda = (DateTime)rows[0][3];
                s.Endda = (DateTime)rows[0][4];
                return s;
            }
            else return null;

        }

        

        // implement insert
        public static void create(string hebrewYear, string type, DateTime start, DateTime end) 
        {

            adapter.InsertQuery(hebrewYear,type,start.ToString(),end.ToString());
        }

        // implement edit
        public void edit(int id, string newYear, string newType, DateTime start, DateTime end)
        {
            this.HebrewYear = newYear;
            this.SemesterType = newType;
            this.Begda = start;
            this.Endda = end;

            adapter.UpdateQuery(HebrewYear, SemesterType, Begda.ToString(), Endda.ToString(),id);
        }

        //implement delete
        public void delete(int id)
        {
            try
            {
                Semester s = Semester.getFromDatabase(id);
                if (s != null)
                {
                    adapter.DeleteQuery(s.Id);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("לא ניתן למחוק פריט זה, בדוק שלא מקושר לדברים אחרים",
                    "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override string ToString()
        {
            return $"{this.SemesterType} {this.HebrewYear}";

        }

    }
}
