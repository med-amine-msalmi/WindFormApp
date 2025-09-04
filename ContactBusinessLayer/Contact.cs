using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDataAccess;
namespace ContactBusinessLayer
{

    public class Contact
    {
        private enum Mode{AddNew,Update};
        private Mode _mode;
        public  int ID { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public  string PhoneNumber { get; set; }
        public  string Address { get; set; }
        public  DateTime DateOfBirth { get; set; }
        public  string ImagePath { get; set; }
        public  int CountryID { get; set; }

        public void toString()
        {
            Console.WriteLine("-----------Contact Information-------------------");
            Console.WriteLine($"\t\tID= {this.ID}");
            Console.WriteLine($"\t\tFirstName={this.FirstName}");
            Console.WriteLine($"\t\tLastName={this.LastName}");
            Console.WriteLine($"\t\tEmail={this.Email}");
            Console.WriteLine($"\t\tPhone Number={this.PhoneNumber}");
            Console.WriteLine($"\t\tAddress={this.Address}");
            Console.WriteLine($"\t\tDate of Birth={this.DateOfBirth.ToString().Split()[0]}");
            Console.WriteLine($"\t\tImage Path={this.ImagePath}");
            Console.WriteLine($"\t\tCountry ID={this.CountryID}");



           
        }
        public Contact()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.PhoneNumber = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.ImagePath = "";
            this.CountryID = CountryID;
            _mode = Mode.AddNew;

        }
        private Contact(int iD, string firstName, string lastName, string email, string phoneNumber, string address, DateTime dateOfBirth, string imagePath, int countryID)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.ImagePath = imagePath;
            this.CountryID = countryID;
            _mode = Mode.Update;
        }

        public static Contact FindContact(int ID)
        {
            string FirstName = ""; string LastName = ""; string Email = ""; string PhoneNumber = "";
            string Address = ""; DateTime DateOfBirth = DateTime.MinValue; string ImagePath = ""; int CountryID = -1;
            
            if(DataAccess.GetContactInfoByID(ID, ref FirstName, ref LastName, ref Email, ref PhoneNumber, ref Address, ref DateOfBirth, ref ImagePath, ref CountryID))
                 return new Contact(ID,FirstName,LastName, Email, PhoneNumber, Address, DateOfBirth, ImagePath, CountryID);
            return null;
        }
        private bool _AddNewContact()
        {
            this.ID = DataAccess.AddContact(this.FirstName, this.LastName, this.Email, this.PhoneNumber, this.Address, this.DateOfBirth, this.ImagePath, this.CountryID);

            return this.ID != 0;
        }
        private bool _UpdateContact()
        {
            return DataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.PhoneNumber, this.Address, this.DateOfBirth, this.ImagePath, this.CountryID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewContact())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;
                case Mode.Update:
                    return _UpdateContact();
                       
                    
                
            }
            return false;
        }

        public static bool Delete(int id)
        {
            return DataAccess.Delete(id);
        }
        
        public static DataTable getContacts()
        {
            return DataAccess.getAllContacts();
        }

        public static bool isExistContact(int id)
        {
            return DataAccess.isExist(id);
        }


    }
}
