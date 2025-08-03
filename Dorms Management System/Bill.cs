using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class Bill
    {
        private int billID;
        private int rentID;
        private double total;
        private bool isPayed;
        private DateTime billDate;
        private DateTime payedDate;
        private double toBePayed;
        private double payed;
        private int userID;
        public Bill(int billID, int rentID, double total, bool isPayed,
            DateTime billDate, DateTime payedDate, double toBePayed, double payed, int userID)
        {
            this.billID = billID;
            this.rentID = rentID;
            this.total = total;
            this.isPayed = isPayed;
            this.billDate = billDate;
            this.payedDate = payedDate;
            this.toBePayed = toBePayed;
            this.payed = payed;
            this.userID = userID;
        }
        public int UserID { get { return userID; } }
        public int BillID { get { return billID; } }
        public double Total { get { return total; } }
        public bool IsPayed { get { return isPayed; } } 
        public DateTime BillDate { get { return billDate; } }
        public DateTime PayedDate { get { return payedDate; } }
        public double ToBePayed { get { return toBePayed; } }
        public double Payed { get { return payed; } }
        public int RentID { get { return rentID; } }
    }
}
