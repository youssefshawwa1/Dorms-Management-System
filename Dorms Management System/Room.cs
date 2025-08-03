using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class Room
    {
        private int roomID;
        private int floorID;
        private string roomNumber;
        private string description;
        private string roomType;

        public Room(
            int roomID, 
            int floorID,
            string roomNumber,
            string description,
            string roomType)
        {
            this.roomID = roomID;
            this.floorID = floorID;
            this.roomNumber = roomNumber;
            this.description = description;
            this.roomType = roomType;
        }
        public int RoomID { get { return this.roomID; } }
        public int FloorID { get { return this.floorID; } }
        public string RoomNumber { get { return this.roomNumber; } }
        public string Description { get { return this.description; } }
        public string RoomType { get { return this.roomType; } }

    }
}
