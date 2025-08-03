using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class Floor
    {
        private int floorID;
        private int floorLevel;
        private string floorName;
        private string floorDescription;
        public Floor(
            int floorID, 
            int floorLevel, 
            string floorName, 
            string floorDescription)
        {
            this.floorID = floorID;
            this.floorLevel = floorLevel;
            this.floorName = floorName;
            this.floorDescription = floorDescription;
        }
        public int FloorID { get { return floorID; } }
        public int FloorLevel { get { return floorLevel; } }
        public string FloorName { get { return floorName; } }
        public string FloorDescription { get { return floorDescription; } }

    }

}
