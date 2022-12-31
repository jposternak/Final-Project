using Final_Project.grilDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public Building building { get; set; }

        public static Dictionary<Features, int> RoomFeatures { get; private set; }


        private static RoomTableAdapter adapter = new RoomTableAdapter();
        private static RoomFeaturesTableAdapter f_adapter = new RoomFeaturesTableAdapter();

        private Room(int id, string name, int floor, Building building, Dictionary<Features, int> roomFeatures)
        {
            Id = id;
            Name = name;
            Floor = floor;
            this.building = building;
            RoomFeatures = roomFeatures;
        }

        public void createRoom(int id, string name, int floor, Building building)
        {
            adapter.InsertQuery(name, Floor, building.Id);

        }

        public static Room GetRoom(int RoomID)
        {
            DataRowCollection rows = adapter.GetDataByRoomID(RoomID).Rows;
            if (rows.Count != 0)
            {
                String roomName = rows[0][1].ToString();
                int floor = (int)rows[0][2];
                int buildingID = (int)rows[0][3];
                Building b = Building.GetBuilding(buildingID);
                RoomFeatures = Room.getRoomFeaturesFromDB(RoomID);
                Room r = new Room(RoomID, roomName, floor, b, RoomFeatures);
                return r;
            }
            else return null;

        }

        public Dictionary<Features, int> getRoomFeatures()
        {
            return RoomFeatures;
        }

        public void changeName(int roomID, String newName, int newFloor, int newBuildingID)
        {
            Room r = Room.GetRoom(roomID);
            r.Name = newName;
            r.Floor = newFloor;
            r.building = Building.GetBuilding(newBuildingID);
            adapter.UpdateQuery(r.Name, r.Floor, r.building.Id, r.Id);
        }

        public void deleteRoom(int roomID)
        {
            try
            {
                Room r = Room.GetRoom(roomID);
                if (r != null)
                {
                    adapter.DeleteQuery(r.Id);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("לא ניתן למחוק חדר זה, בדוק שלא מקושר לדברים אחרים",
                    "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Dictionary<Features, int> getRoomFeaturesFromDB(int roomID)
        {

            Dictionary<Features, int> features = new Dictionary<Features, int>();           
            DataRowCollection rows = f_adapter.GetDataByRoomID(roomID).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int f_id = (int)rows[i][1];
                Features f = Features.GetFeatures(f_id);
                int qual = (int)rows[i][2];
                features.Add(f, qual);
            }

            return features;

        }


        public void removeFeature(Features feature)
        {
            RoomFeatures.Remove(feature);
            f_adapter.DeleteQuery(Id, feature.Id);
        }

        public void addFeature(Features feature, int qualifier)
        {
            RoomFeatures.Add(feature,qualifier);
            f_adapter.InsertQuery(Id,feature.Id, qualifier);
        }

        public override string ToString()
        {
            return $"{building.Campus.Name}\t{building.Name}\n{Name}";
        }


    }
}









