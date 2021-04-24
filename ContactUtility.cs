using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class ContactUtility
    {
        public List<Contact> list = new List<Contact>();
        
        public void FunctionEdit()
        {
            Console.WriteLine("Edit");
            foreach (var data in list)
            {
                Console.WriteLine("first Name  " + data.Name + "\nMobile Number  " + data.Number);
                Console.WriteLine("**************************************************************");
            }
            Console.WriteLine("Enter first name from the list");
            string first = Console.ReadLine();
            foreach (Contact data in list)
            {
                if (data.Name == first)
                {
                    Console.WriteLine("Choosen to edit first name  " + data.Name + "\nEnter new name");
                    first = Console.ReadLine();
                    data.Name = first;
                }
                break;
            }
        }

        public void FunctionAdd()
        {
            Console.WriteLine("You have choosen to add or create new contact");
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Adress");
            string adress = Console.ReadLine();
            Console.WriteLine("Enter city name");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Number");
            string number = (Console.ReadLine());
            list.Add(new Contact(firstName, number,lastName,adress,city));
            
        }

        public void FunctionDelete()
        {
            Console.WriteLine("Delete");
            Console.WriteLine("Enter first name");
            string first = Console.ReadLine();
            for (int j = 0; j < list.Count; j++)
            {
                if ( list[j].Name == first)
                {
                    list.RemoveAt(j);
                }
            }
        }
        public void FunctionPrint()
        {
            foreach (var data in list)
            {
                Console.WriteLine("first Name  " + data.Name + "\nMobile Number  " + data.Number+"\nLastName  "+data.Lastname+"\nAdress  "+data.Adress+"\nCity  "+data.City);
                Console.WriteLine("*************************************************************************************");
            }

        }
    }
}   
