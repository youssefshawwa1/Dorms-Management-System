using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    internal class University
    {
        private int UniversityID;
        private string UniversityName;
        private string UniversityDescription;
        private string UniversityAddress;

        public University(
            int universityID, 
            string universityName, 
            string universityDescription, 
            string universityAddress)
        {
            this.UniversityID = universityID;
            this.UniversityName = universityName;
            this.UniversityDescription = universityDescription;
            this.UniversityAddress = universityAddress;
        }
    }
}
