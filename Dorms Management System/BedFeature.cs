using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class BedFeature
    {
        private int featureID;
        private string featureName;
        private double price;
        private string description;
        private string featureInfo;

        public BedFeature(
            int featureID, 
            string featureName, 
            double price, 
            string description)
        {
            this.featureID = featureID;
            this.featureName = featureName;
            this.price = price;
            this.description = description;
            this.featureInfo = $"{this.featureName}    -   {this.Price.ToString("C")}";
        }

        public int FeatureID { get { return featureID; } }
        public string FeatureName { get { return featureName; } }
        public double Price { get { return price; } }
        public string Description { get { return description; } }
        public string FeatureInfo { get { return featureInfo; } }
    }
}
