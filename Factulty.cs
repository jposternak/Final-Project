using Final_Project.grilDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static FacultyTableAdapter adapter = new FacultyTableAdapter();

        private Faculty(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public static void create(string name)
        {
            adapter.InsertQuery(name);
        }

        public static Faculty getFaculty(int facultyID)
        {
            DataRowCollection rows = adapter.GetDataByID(facultyID).Rows;

            if (rows.Count != 0)
            {
                String name = rows[0][1].ToString();
                Faculty f = new Faculty(facultyID,name);
                return f;
            }
            else return null;

        }

        public void changeName(int f_id, string newName)
        {
            Faculty faculty = getFaculty(f_id);
            faculty.Name = newName;
            adapter.UpdateQuery(faculty.Name, faculty.Id);
        }

        public void deleteRoom(int f_id)
        {
            try
            {
                Faculty faculty = getFaculty(f_id);
                if (r != null)
                {
                    adapter.DeleteQuery(f_id);
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
