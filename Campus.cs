using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
    [Serializable]
    internal class Campus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Campus (int Id, String name)
        {
            this.Id = Id;
            this.Name = name;
        }
    }
}
