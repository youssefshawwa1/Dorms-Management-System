using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{


    public class RentInfo
    {
        private int rentID;
        private int clientID;
        private string name;
        private string phoneNumber;
        private string roomNumbers;
        private string bedNamse;
        private string type;
        private DateTime checkInDate;
        private DateTime? checkOutDate;
        private DateTime mustCheckOutOn;
        private string bedFeatures;
        private string roomServices;
        private int roomID;
        private int? bedID;
        private string userName;
        private string roomType;
        public RentInfo(
            int rentID,
            int clientID,
            string name,
            string phoneNumber,
            string roomNumbers,
            string bedNamse,
            string type,
            DateTime checkInDate,
            DateTime? checkOutDate,
            DateTime mustCheckOutOn,
            string bedFeatures,
            string roomServices,
            int roomID,
            int? bedID,
            string roomType,
            string userName)
        {
            this.rentID = rentID;
            this.clientID = clientID;
            this.roomNumbers = roomNumbers;
            this.bedNamse = bedNamse;
            this.type = type;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.mustCheckOutOn = mustCheckOutOn;
            this.roomID = roomID;
            this.bedID = bedID;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.userName = userName;
            this.bedFeatures = bedFeatures;
            this.roomServices = roomServices;
            this.roomType = roomType;
        }
        public string RoomType  { get {return this.roomType; } }
        public  string BedFeatures { get { return this.bedFeatures; } }
        public string RoomServices { get { return this.roomServices; } }
        public string UserName { get { return this.userName; } set { this.userName = value; } }
        public int RentID { get { return rentID; } set { rentID = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public int ClientID { get { return clientID; } set { clientID = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string RoomNumber { get { return roomNumbers; } set { roomNumbers = value; } }
        public string BedNamse { get { return bedNamse; } set { bedNamse = value; } }
        public string Type { get { return type; } set { type = value; } }
        public DateTime CheckInDate { get { return checkInDate; } set { checkInDate = value; } }
        public DateTime? CheckOutDate { get { return checkOutDate; } set { checkOutDate = value; } }
        public DateTime MustCheckOutOn { get { return mustCheckOutOn; } set { mustCheckOutOn = value; } }
        public int RoomID { get { return roomID; } set { roomID = value; } }
        public int? BedID { get { return bedID; } set { bedID = value; } }
    }
}