//==============================================================//
//					        Group.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This class creates a Group object that contains     //
//          all pertinent data.                                 //
//==============================================================//
/* 
Authors: Joshua Boone and Justine Dinh                     
Cycle 3 Changes:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaptorMath
{
    //------------------------------------------------------------------//
    // Authors: Cody Jordan, Cian Carota                                //
    // Date: 4/1/14                                                     //
    //------------------------------------------------------------------//
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Group object default constructor.</summary>
        public Group()
        {
            Name = "Unknown";
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Drill object constructor.</summary>
        /// <param name="groupName">Group Name.</param>
        public Group(string groupName)
        {
            Name = groupName;
        }
    }
}
