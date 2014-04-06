using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaptorMath
{
    public class Group
    {
        public List<Drill> groupDrillList = new List<Drill>();

        private int id;
        private string name;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value;  }
        }

        public Group()
        {
            Name = "Unknown";
        }

        public Group(string groupName)
        {
            Name = groupName;
        }
    }
}
