using ControlzEx.Standard;
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
    public class Building
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Campus Campus { get; private set; }

        private static BuildingTableAdapter adapter = new BuildingTableAdapter();

        private Building(int id, string name, Campus campus)
        {
            this.Id = id;
            this.Name = name;
            this.Campus = campus;
        }


        public void createBuilding(String BuildingName, Campus Campus)
        {
            adapter.InsertQuery(BuildingName, Campus.Id);
        }

        public static Building GetBuilding(int buildingID)
        {
            DataRowCollection rows = adapter.GetDataByID(buildingID).Rows;
            if (rows.Count != 0)
            {
                String campusName = rows[0][1].ToString();
                int campusID = (int)rows[0][2];
                Campus c = Campus.getCampus(campusID);
                Building b = new Building(buildingID, campusName, c);
                return b;
            }
            else return null;

        }

        public void changeName(int buildingID, String newName)
        {
            Building b = Building.GetBuilding(buildingID);
            b.Name = newName;
            adapter.UpdateQuery(newName,b.Campus.Id ,b.Id);
        }

        public void changeCampus(int buildingID, int newCampusID)
        {
            Building b = Building.GetBuilding(buildingID);
            b.Campus = Campus.getCampus(newCampusID);
            adapter.UpdateQuery(b.Name, newCampusID, b.Id);
        }

        public void deleteBuilding(int buildingID)
        {
            try
            {
                Building b = Building.GetBuilding(buildingID);
                if (b != null)
                {
                    adapter.DeleteQuery(b.Id);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("לא ניתן למחוק בניין זה, בדוק שלא מקושר לחדרים",
                    "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
