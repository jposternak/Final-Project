using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
    [Serializable]
    internal class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        Building building { get; set; }
        Dictionary<Features,int> RoomFeatures { get; set; }
    }
}
