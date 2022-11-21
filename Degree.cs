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
    public class Degree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }

        static DegreeTableAdapter adapter = new DegreeTableAdapter();

        private Degree(int id, string name, Faculty faculty)
        {
            Id = id;
            Name = name;
            Faculty = faculty; 
        }

        public void Create(string name, Faculty faculty)
        {
            adapter.InsertQuery(name, faculty.Id);
        }

        static public Degree getFromDatabase(int id)
        {
            DataRowCollection rows = adapter.GetDataByID(id).Rows;

            if (rows.Count != 0)
            {
                String name = rows[0][1].ToString();
                int f_id = (int)rows[0][2];
                Faculty f = Faculty.getFaculty(f_id);
                Degree d = new Degree(id, name, f);
                return d;
            }
            else return null;
        }

        public void changeProperties(int id, string newName,int newFacultyId)
        {
            Faculty = Faculty.getFaculty(newFacultyId);
            Name = newName;
            adapter.UpdateQuery(Name,Faculty.Id,id);
        }

        public void deleteDegree(int id)
        {
            try
            {
                Degree d = getFromDatabase(id);
                if (d != null)
                {
                    adapter.DeleteQuery(d.Id);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("לא ניתן למחוק פריט זה, בדוק שלא מקושר לדברים אחרים",
                    "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
