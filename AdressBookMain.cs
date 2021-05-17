using System;
using System.Collections.Generic;

namespace AdressBook
{
    class AdressBookMain
    {
        const string FILE_PATH = @"C:\Users\chauh\OneDrive\Desktop\gitIgnore\AdressBook\Files\AdressBook.txt";
        const string FILE_PATH_CSV = @"C:\Users\chauh\OneDrive\Desktop\gitIgnore\AdressBook\Files\AdressBook.csv";
        const string FILE_PATH_JSON = @"C:\Users\chauh\OneDrive\Desktop\gitIgnore\AdressBook\Files\AdressBook_To_JSON.txt";
        static void Main(string[] args)
        {
            FileOperation file = new FileOperation();
            ContactUtility utility = new ContactUtility();
            int i = 0;
            while (i<1)
            {
                try

                {
                    Console.WriteLine("Insert your option\n 1.Addition\n 2.Name Editing\n 3.Deleting" +

                        "\n 4.PrintAdressBook \n 5.Exit\n 6.Find City Name of Person\n" +
                        " 7.Find All Person of that City\n 8.Sort By First Name\n 9.Sort By City Name\n" +
                        "10. Wrtie AdressBook To Text\n" +
                        "11. Write AdressBook To CSV\n 12. Write AddresBook to JSON");
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
                            utility.Search_City_Of_Person();
                            break;
                        case 7:
                            utility.Find_All_Person_In_City();
                            break;
                        case 8:
                            utility.Sort_By_First_Name();
                            break;
                        case 9:
                            utility.Sort_By_City_Adress_Zip_Name();
                            break;
                        case 10:
                            file.Write_AdressBook_To_Text(FILE_PATH, utility.contactList);
                            break;
                        case 11:
                            file.Write_AdressBook_To_CSV(FILE_PATH_CSV, utility.contactList);
                            break;
                        case 12:
                            file.Write_AdressBook_To_JSON(FILE_PATH_JSON, utility.contactList);
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
