using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Text;
using CsvHelper.Configuration;

namespace AdressBook
{
    class FileOperation
    {
        public void Write_AdressBook_To_Text(string filePath,List<Contact> list)
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
        public void Write_AdressBook_To_CSV(string filePath, List<Contact> list)
        {
            bool append = true;
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = !append;
            using (var writer = new StreamWriter(filePath,append))
            {
                using (var contact = new CsvWriter(writer, config))
                {
                    contact.WriteRecords(list);
                }
            }
        }
    }
}
