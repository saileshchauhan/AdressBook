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
            return "FirstName_ of Contact : " +this.Name+"LastName of Contact : "+this.Lastname;
        }
    }
}
