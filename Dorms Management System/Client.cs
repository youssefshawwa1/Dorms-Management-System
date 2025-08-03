using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{ 
    public class Client
    {

    private int clientID;
    private string passportID;
    private string phoneNumber;
    private string firstName;
    private string lastName;
    private string middleName;
    private string university;
    private DateTime birthOfDate;
    private string gender;
    private DateTime insertionDate;
    private string emergencyContactName;
    private string emergencyContactRelation;
    private string emergencyContactPhone;
    private string email;
    private string emergencyContactEmail;
    private List<Rent> Rent;
    private string fullName;
    private string fullNameWithNumber;
        public Client(
            int id,
            string passport,
            string phone,
            string fn,
            string mn,
            string ln,
            string uni,
            DateTime birth,
            string gender,
            DateTime insertionDate,
            string eName,
            string eRelation,
            string ePhone,
            string eEmail,
            string Email)
        {
            //initialize the Client object with the inserted data.
            this.clientID = id;
            this.passportID = passport;
            this.firstName = fn;
            this.lastName = ln;
            this.middleName = mn;
            this.university = uni;
            this.birthOfDate = birth;
            this.insertionDate = insertionDate;
            this.gender = gender;
            this.emergencyContactName = eName;
            this.emergencyContactRelation = eRelation;
            this.emergencyContactPhone = ePhone;
            this.phoneNumber = phone;
            this.email = Email;
            this.emergencyContactEmail = eEmail;
            this.fullName = fn + " " + mn + " " + ln;
            this.fullNameWithNumber = fullName + "-" + phoneNumber; 
            this.Rent = new List<Rent>();
        }
        public int ClientID { get { return clientID; } set { this.clientID = value; } }
        public string PassportID { get { return passportID; }set { this.passportID = value; } }
        public string FirstName { get { return firstName; }set { this.firstName = value; } }
        public string LastName { get { return lastName; }set { this.lastName = value; } }
        public string MiddleName { get { return middleName; }set { this.middleName = value; } }
        public string UniversityName { get { return university; }set { this.university = value; } }
        public DateTime BirthDate { get { return birthOfDate; } set { this.birthOfDate = value; } }
        public DateTime InsertionDate { get { return insertionDate; } set { this.insertionDate = value; } }
        public string Gender { get { return gender; } set { this.gender = value; } }
        public string EmergencyContactName { get { return emergencyContactName; } set { this.emergencyContactName = value; } }
        public string EmergencyContactRelation { get { return emergencyContactRelation; } set { this.emergencyContactRelation = value; }}
        public string EmergencyContactPhone { get { return emergencyContactPhone; } set { this.emergencyContactPhone = value; } }
        public string EmergencyContactEmail { get { return emergencyContactEmail; } set { this.emergencyContactEmail = value; } }
        public string Email { get { return email; } set { this.email = value; } }
        public string Phone { get { return phoneNumber; } set { this.phoneNumber = value; } }
        public string FullNameWithNumber { get { return fullNameWithNumber; } }
        public string FullName { get { return fullName; } }
    }


}