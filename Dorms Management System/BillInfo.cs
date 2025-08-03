using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class BillInfo
    {
        //RentID = r.RentID,
        //            FullName = r.FullName,
        //            Phone = r.Phone,
        //            Room = r.Room,
        //            Bed = r.Bed,
        //            Type = r.Type,
        //            RoomType = r.RoomType,
        //            IsPayed = r.IsPayed,
        //            BillDate = r.BillDate,
        //            PayedDate = r.PayedDate,
        //            ToBePayed = r.ToBePayed,
        //            Payed = r.Payed,
        //            UserName = userName

        private int rentId;
        private string name;
        private string phone;
        private string room;
        private string bed;
        private string type;
        private string roomType;
        private bool isPayed;
        private DateTime billDate;
        private DateTime? payedDate;
        private double toBePayed;
        private double payedAmount;
        private string userName;
        private double total;
        private int billID;

        public BillInfo(int billID, int rentID, string name, string phone, string room, string bed, string type, string roomType, bool isPayed,
            DateTime billDate, DateTime? payedDate,double total, double toBePayed, double payedAmount, string userName)
        {
            this.billID = billID;
            this.rentId = rentID;
            this.name = name;
            this.phone = phone;
            this.room = room;
            this.bed = bed;
            this.type = type;
            this.roomType = roomType;
            this.isPayed = isPayed;
            this.billDate = billDate;
            this.payedDate = payedDate;
            this.payedAmount = payedAmount;
            this.payedDate = payedDate;
            this.toBePayed = toBePayed;
            this.userName = userName;
            this.total = total;
        }
        public int BillID { get { return billID; } }
        public int RentID { get { return rentId; }  }
        public string FullName { get { return name; } }
        public string Phone { get { return phone; } }
        public string Room { get { return room; } }
        public string Bed { get { return bed; } }
        public string Type { get { return type; } }
        public string RoomType { get { return roomType; } }
        public bool  IsPayed { get { return isPayed; } }
        public DateTime BillDate { get { return billDate; } }
        public DateTime? PayedDate { get { return payedDate; } }
        public double Payed { get { return payedAmount; } }
        public double Total { get { return total; } }
        public double ToBePayed { get { return toBePayed; } }
        public string UserName { get { return userName; } }
    }
}
