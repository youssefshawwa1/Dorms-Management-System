using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class Rent
    {
        private int rentID;
        private int tenantID;
        private int? bedID;
        private int roomID;
        private DateTime checkInDate;
        private DateTime? checkOutDate;
        private DateTime estimateCheckOut;
        private string type;
        private int userID;

        public Rent(
            int rentID, 
            int tenantID,
            int? bedID,
            int roomID,
            DateTime checkInDate,
            DateTime? checkOutDate,
            DateTime estimateCheckOut,
            string type,
            int userID)
        {
            this.rentID = rentID;
            this.tenantID = tenantID;
            this.bedID = bedID;
            this.roomID = roomID;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.estimateCheckOut = estimateCheckOut;
            this.type = type;
            this.userID = userID;
        }
        public int UserID { get { return userID; } }
        public int RentID { get { return rentID; } }
        public int ClientID { get { return tenantID; } }
        public int? BedID { get { return bedID; } }
        public int RoomID { get { return roomID; } }
        public DateTime CheckInDate { get { return checkInDate; } }
        public DateTime? CheckOutDate { get { return checkOutDate; } }
        public DateTime EstimateCheckOUt { get { return estimateCheckOut; } }
        public string Type { get { return type; } }
    }
}
