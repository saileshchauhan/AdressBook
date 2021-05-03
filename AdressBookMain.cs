﻿using System;
using System.Collections.Generic;

namespace AdressBook
{
    class AdressBookMain
    {
        static void Main(string[] args)
        {
            ContactUtility utility=new ContactUtility();

            int i = 0;
            while (i<1)
            {
                try

                {
                    Console.WriteLine("Insert your option\n 1.Addition\n 2.Name Editing\n 3.Deleting" +

                        "\n 4.PrintAdressBook \n 5.Exit\n 6.DuplicateCheck\n 7.Find City Name of Person");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            utility.FunctionAdd();
                            break;
                        case 2:
                            utility.FunctionEdit();
                            break;
                        case 3:
                            utility.FunctionDelete();
                            break;
                        case 4:
                            utility.FunctionPrint();
                            break;
                        case 5:
                            i = 1;
                            Console.WriteLine("You have exited from the adress Book");
                            break;
                        case 6:
                            utility.DuplicateEntryCheck();
                            break;
                        case 7:
                            utility.Search_City_Of_Person();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("User Has entered invalid input");
                }
                
            }
        }
    }
}
