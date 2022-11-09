using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    [Serializable]
    internal class DegreeClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Degree Degree { get; set; }
        public int NumberOfStudents { get; set; }
        public Semester StartingSemester { get; set; }  
        public int Duration { get; set; }
        public bool Summer { get; set; }
        public int WeeklyHours { get; set; }
    }
}
