using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
    [Serializable]
    internal class Semester
    {
        public int Id { get; set; }
        public string HebrewYear { get; set; }
        public string SemesterType { get; set; }
        public DateTime Begda { get; set; }
        public DateTime Endda { get; set; }

    }
}
