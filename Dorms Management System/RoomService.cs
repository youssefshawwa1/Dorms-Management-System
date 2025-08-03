using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class RoomService
    {
        private int serviceID;
        private string serviceName;
        private double price;
        private string description;
        private string serviceInfo;
        public RoomService (
            int serviceID, 
            string serviceName, 
            double price, 
            string description)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.price = price;
            this.description = description;
            this.serviceInfo = $"{this.ServiceName}    -   {this.price.ToString("C")}";
        }

        public int ServicID { get { return serviceID; } }
        public string ServiceName { get { return serviceName; } }
        public double Price { get { return price; } }
        public string Description { get { return description; } }
        public string ServiceInfo { get { return serviceInfo; } }
    }
}
