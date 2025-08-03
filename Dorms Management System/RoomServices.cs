using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class RoomServices
    {
        private int roomServicesID;
        private int serviceID;
        private int rentID;

        public RoomServices(
            int roomServicesID, 
            int serviceID, 
            int rentID)
        {
            this.roomServicesID = roomServicesID;
            this.serviceID = serviceID;
            this.rentID = rentID;
        }
        public int RoomServicesID { get { return roomServicesID; } }
        public int ServiceID { get { return serviceID; } }
        public int RentID { get { return rentID; } }
    }
}
