using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    [Serializable]
    internal class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CampusID { get; set; }
    }
}
