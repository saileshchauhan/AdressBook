using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdressBook
{
    class FileOperation
    {
        
        public void Write_AdressBook_To_TextFile(string filePath,List<Contact> list)
        {
            using (StreamWriter sr = File.AppendText(filePath))
            {
                foreach (Contact contact in list)
                {
                    sr.WriteLine("New Contact Entry");
                    sr.WriteLine(contact.Name + "\n" + contact.Lastname + "\n" + contact.Adress + "\n" + contact.City + "\n" + contact.Number);
                }
                sr.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }

        }
    }
}
