using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class ContactUtility
    {
        public List<Contact> mylist = new List<Contact>();
        public Dictionary<string,Contact> adresBookDictionary = new Dictionary<string,Contact>();
       // public Dictionary<string, List<Contact> adresBookDictionary = new Dictionary<string,List<Contact>();
        
        public void FunctionEdit()
        {
            Console.WriteLine("Edit");
            foreach (var element in adresBookDictionary)
            {
                Console.WriteLine("Adress Book Name :::" + element.Key);
                Console.WriteLine("*************************************************************************************");
            }
            Console.WriteLine("Enter Name of Adress book to Edit");
            string AdressBookToEdit = Console.ReadLine();
            Console.WriteLine("AdressBookName ::::" + AdressBookToEdit);
            foreach (var data in adresBookDictionary)
            {
                if (data.Key.Equals(AdressBookToEdit))
                {
                    Console.WriteLine("first Name  " + data.Value.Name + "\nMobile Number  " + data.Value.Number + "\nLastName  " + data.Value.Lastname + "\nAdress  " + data.Value.Adress + "\nCity  " + data.Value.City);
                    Console.WriteLine("Enter first name from the list");
                    string first = Console.ReadLine();
                    if (data.Value.Name.Equals(first))
                    {
                        Console.WriteLine("Choosen to edit first name  " + data.Value.Name + "\nEnter new name");
                        first = Console.ReadLine();
                        data.Value.Name = first;
                    }
                }
            }
            Console.WriteLine("*************************************************************************************");

            //foreach (var data in mylist)
            //{
            //    Console.WriteLine("first Name  " + data.Name + "\nMobile Number  " + data.Number);
            //    Console.WriteLine("**************************************************************");
            //}
            //Console.WriteLine("Enter first name from the list");
            //string first = Console.ReadLine();
            //foreach (Contact data in mylist)
            //{
            //    if (data.Name == first)
            //    {
            //        Console.WriteLine("Choosen to edit first name  " + data.Name + "\nEnter new name");
            //        first = Console.ReadLine();
            //        data.Name = first;
            //    }
            //    break;
            //}
        }

        public void FunctionAdd()
        {
            Console.WriteLine("You have choosen to add or create new contact");
            Console.WriteLine("Enter a unique name for your AdressBook");
            string adressBookName = Console.ReadLine();
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
            //mylist.Add(new Contact(firstName, number,lastName,adress,city));
            Contact contact = new Contact(firstName, lastName, adress, city, number);
            adresBookDictionary.Add(adressBookName, contact);
            PrintOnly_AdressBook_And_Keys();
           // mylist.RemoveRange(0,1);
        }

        public void FunctionDelete()
        {
            Console.WriteLine("Delete");
            Console.WriteLine("Enter first name");
            string first = Console.ReadLine();
            for (int j = 0; j < mylist.Count; j++)
            {
                if ( mylist[j].Name == first)
                {
                    mylist.RemoveAt(j);
                }
            }
        }
        public void FunctionPrint()
        {
            PrintOnly_AdressBook_And_Keys();
            Console.WriteLine("Enter Name of Adress to open :::::\nEnter All for printing every Adress Book");
            string readAdressBookName = Console.ReadLine();
            if (readAdressBookName.ToLower().Equals("all"))
            {
                foreach (var data in adresBookDictionary)
                {
                    Console.WriteLine("Adress Book Name ::: "+data.Key);
                    Console.WriteLine("first Name  " + data.Value.Name + "\nMobile Number  " + data.Value.Number + "\nLastName  " + data.Value.Lastname + "\nAdress  " + data.Value.Adress + "\nCity  " + data.Value.City);
                    Console.WriteLine("*************************************************************************************");
                }
                      
            }
            else
            {
                Console.WriteLine("AdressBookName ::::" + readAdressBookName);
                foreach (var data in adresBookDictionary)
                {
                    if (data.Key.Equals(readAdressBookName))
                    {
                        Console.WriteLine("first Name  " + data.Value.Name + "\nMobile Number  " + data.Value.Number + "\nLastName  " + data.Value.Lastname + "\nAdress  " + data.Value.Adress + "\nCity  " + data.Value.City);
                    }
                }
                Console.WriteLine("*************************************************************************************");
            }
        }
        public void DuplicateEntryCheck()
        {
            Console.WriteLine("Enter First Name ");
            string firstName = Console.ReadLine();
            foreach(var data in adresBookDictionary)
            {
                if (data.Value.Name.Equals(firstName))
                {
                    Console.WriteLine("Contact Entry already Exist in AdressBook :::  " + data.Key);
                }
                else 
                {
                    Console.WriteLine("No Such Contact found in any AdressBook  "+firstName);
                }
            }
        }
        public void PrintOnly_AdressBook_And_Keys()
        {
            foreach (var element in adresBookDictionary)
            {
                Console.WriteLine("Adress Book Name :::" + element.Key);
                Console.WriteLine("*************************************************************************************");
            }
        }
    }
}   
