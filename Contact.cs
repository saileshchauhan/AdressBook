using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class Contact
    {
        
        public string Name { get; set; }
        public string Number { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }


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
