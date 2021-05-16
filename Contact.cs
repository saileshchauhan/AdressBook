using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class Contact
    {
        
        public string Name;
        public string Number;
        public string Lastname;
        public string Adress;
        public string City;
        
        
        public Contact(string name, string number,string lastname,string adress,string city)
        {
            this.Name = name;
            this.Number = number;
            this.Lastname = lastname;
            this.Adress = adress;
            this.City = city;
        }
        public override string ToString()
        {
            return "Name of Contact in sorted order : " + Name;
        }
    }
}
