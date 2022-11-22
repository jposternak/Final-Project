using Final_Project.grilDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Campus
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private static campusTableAdapter adapter = new campusTableAdapter();
        private Campus (int Id, String Name)
        {
            this.Id = Id;  
            this.Name = Name;
        }

        public void createCampus(String CampusName)
        {
            adapter.InsertQuery(CampusName);
        }


        public static Campus getCampus(int campusID)
        {
            DataRowCollection rows = adapter.GetDataByID(campusID).Rows;
            if (rows.Count != 0)
            {
                String campusName = rows[0][1].ToString();
                return new Campus(campusID, campusName);
            }
            else return null;
        }

        public void changeName(int campusID, String newName)
        {
            Campus c = Campus.getCampus(campusID);
            c.Name = newName;
            adapter.UpdateQuery(newName, campusID);
        }

        public void deleteCampus(int campusID)
        {
            try
            {
                Campus c = Campus.getCampus(campusID);
                if (c != null)
                {
                    adapter.DeleteQuery(campusID);
                }
            }catch (Exception e1)
            {
                MessageBox.Show("לא ניתן למחוק קמפוס זה, בדוק שלא מקושר לבניין",
                    "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
