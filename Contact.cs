using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
 public class Contact
    {
        
        public string Name { get; set; }
        public string Number { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public int ID { get; set; }

        public Contact(int ID,string Name, string Lastname,string Adress,string city,string Number)
        {
            this.ID = ID;
            this.Name = Name;
            this.Lastname = Lastname;
            this.Adress = Adress;
            this.City = city;
            this.Number = Number;
        }
        public Contact(string Name, string Number, string Lastname, string Adress, string City)
        {
            this.Name = Name;
            this.Number = Number;
            this.Lastname = Lastname;
            this.Adress = Adress;
            this.City = City;
        }
        public override string ToString()
        {
            return "FirstName_ of Contact : " + this.Name + "LastName of Contact : " + this.Lastname;
        }
    }
}
