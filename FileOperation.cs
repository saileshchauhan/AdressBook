using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System.Linq;

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
                    sr.WriteLine(contact.Name+" "+contact.Number+ " " +contact.Lastname+ " " + contact.Adress+ " " + contact.City);
                }
                sr.Close();
               // Console.WriteLine(File.ReadAllText(filePath));
            }
        }
        public void Write_AdressBook_To_CSV(string filePath, List<Contact> list)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(list);
            }
        }
        public void Write_AdressBook_To_JSON(string filePath, List<Contact> list)
        {
            JsonSerializer serializer = new JsonSerializer();
            using StreamWriter sw = new StreamWriter(filePath);
            using JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, list);
            File.AppendText(filePath);
        }
        // Read Method
        public List<Contact> Read_CSV_To_AddressBook(string sourceFilePath)
        {
            using (var reader = new StreamReader(sourceFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var list = csv.GetRecords<Contact>().ToList();
                foreach (var record in list)
                {
                    Console.WriteLine(record.Name);
                }
                return list;
            }
        }
        public List<Contact> Read_JSON_To_AddressBook(string sourceFiePath)
        {
            string contentOf_Json = File.ReadAllText(sourceFiePath);
            List<Contact> list = JsonConvert.DeserializeObject<List<Contact>>(contentOf_Json);
            return list;
        }
        public List<Contact> Read_Text_To_AddressBook(string sourceFiePath)
        {
            List<Contact> list = new List<Contact>();
            string[] allLines = File.ReadAllLines(sourceFiePath);
            foreach(var line in allLines)
            {
                string[] word = line.Split(" ");
                list.Add(new Contact(word[0], word[1], word[2], word[3], word[4]));
            }
            return list;
            
        }
        
    }
}
