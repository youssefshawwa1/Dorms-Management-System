using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class Bed
    {
        private int bedID;
        private int roomID;
        private string bedLabel;
        private string status;
        private double price;
        private string bedInfo;
        public Bed(
            int bedID, 
            int roomID,
            string bedLabel,
            string status,
            double price)
        {
            this.bedID = bedID;
            this.roomID = roomID;
            this.bedLabel = bedLabel;
            this.status = status;
            this.price = price;
            this.bedInfo = $"{bedLabel}    -   {price.ToString("C")}";
        }
        public int BedID { get { return bedID; } }
        public int RoomID { get { return roomID; } }
        public string BedLabel { get { return bedLabel; } }
        public double Price { get { return price; } }
        public string Status { get { return status; } }
        public string BedInfo { get { return this.bedInfo; } }
    }
}
