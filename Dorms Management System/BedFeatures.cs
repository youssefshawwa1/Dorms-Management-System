using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class BedFeatures
    {
        private int bedFeaturesID;
        private int featureID;
        private int rentID;

        public BedFeatures(
            int bedFeaturesID, 
            int featureID, 
            int rentID
           )
        {
            this.bedFeaturesID = bedFeaturesID;
            this.featureID = featureID;
            this.rentID = rentID;
        }
        public int BedFeaturesID { get { return bedFeaturesID; } }
        public int FeatureID { get { return featureID; } }
        public int RentID { get { return rentID; } }
    }
}
