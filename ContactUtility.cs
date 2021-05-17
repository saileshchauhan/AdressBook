using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdressBook
{
    class ContactUtility
    {
         Dictionary<string, Contact> adresBookDictionary = new Dictionary<string, Contact>();
         public List<Contact> contactList = new List<Contact>();
        

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
        }

        public void FunctionAdd()
        {
            Console.WriteLine("You have choosen to add or create new contact");
            Console.WriteLine("Enter a unique name for your AdressBook");
            string adressBookName = Console.ReadLine();
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();
            foreach (var data in adresBookDictionary)
            {
                if (data.Value.Name.Equals(firstName))
                {
                    Console.WriteLine("Contact Entry already Exist in AdressBook :::  " + data.Key);
                    return;
                }
                else
                {
                    Console.WriteLine("No Such Contact found in any AdressBook  " + firstName);
                    break;
                }
            }
            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Adress");
            string adress = Console.ReadLine();
            Console.WriteLine("Enter city name");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Number");
            string number = Console.ReadLine();
            // object created for dictionary
            Contact contact = new Contact(firstName, number, lastName, adress, city);
            // list created for UC 11-Sorting
            contactList.Add(new Contact(firstName, number, lastName, adress, city));
            // dictionary created for UC6-UC10
            adresBookDictionary.Add(adressBookName, contact);
            PrintOnly_AdressBook_And_Keys();
        }

        public void FunctionDelete()
        {
            Console.WriteLine("Delete");
            Console.WriteLine("Enter first name");
            string first = Console.ReadLine();
            foreach (var data in adresBookDictionary)
            {
                if (data.Value.Name.Equals(first.ToLower()))
                    adresBookDictionary.Remove(data.Key);
            }
            foreach (Contact contact in contactList)
            {
                if (contact.Name.Equals(first.ToLower()))
                {
                    int index = contactList.IndexOf(contact);
                    contactList.RemoveAt(index);
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
                    Console.WriteLine("Adress Book Name ::: " + data.Key);
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
        public void PrintOnly_AdressBook_And_Keys()
        {
            foreach (var element in adresBookDictionary)
            {
                Console.WriteLine("Adress Book Name :::" + element.Key);
                Console.WriteLine("*************************************************************************************");
            }
        }
        public void Search_City_Of_Person()
        {
            Console.WriteLine("Enter name of person to get there City ");
            string personName = Console.ReadLine();
            foreach (var data in adresBookDictionary)
            {
                if (data.Value.Name.Equals(personName.ToLower()))
                {
                    Console.WriteLine("Person Name  " + data.Value.Name + "\n Found in City " + data.Value.City);
                }
            }
        }
        public void Find_All_Person_In_City()
        {
            int personCount = 0;
            Console.WriteLine("Enter name of city to find all persons ");
            string cityName = Console.ReadLine();
            foreach (var data in adresBookDictionary)
            {
                if (data.Value.City == cityName.ToLower())
                {
                    Console.WriteLine("Person find in City " + data.Value.City + "\nPerson Name " + data.Value.Name);
                    personCount++;
                }
            }
            Console.WriteLine("Total No. of Persons in City " + cityName + " are " + personCount);
        }
        public void Sort_By_First_Name()
        {
            contactList.Sort(delegate (Contact contact1, Contact contact2) 
            { 
                return contact1.Name.CompareTo(contact2.Name); 
            }
            );
            Console.WriteLine(string.Join(Environment.NewLine,contactList));
        }
        public void Sort_By_City_Adress_Zip_Name()
        {
            contactList.Sort(delegate (Contact contact1, Contact contact2) { return contact1.City.CompareTo(contact2.City); });
           // contactList.Sort(delegate (Contact contact1, Contact contact2) { return contact1.Adress.CompareTo(contact2.Adress); });
           // contactList.Sort(delegate (Contact contact1, Contact contact2) { return contact1.Number.CompareTo(contact2.Number); });
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("contact name {0} contact city {1} contact Adress {2} contact Number {3} in sorted order ",contact.Name,contact.City,contact.Adress,contact.Number);
            }
        }
    }
}   
