using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdressBook
{
    class DataBaseReadWrite
    {
        public static string ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=AddressBook_Service;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection( ConnectionString);

        
        public List<Contact> ReadFromDataBase(List<Contact> list)
        {
            try
            {
                using (connection)
                {
                    string query = "SELECT * FROM AddressBook";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string Name = reader.GetString(1);
                            string Lastname = reader.GetString(2);
                            string Adress = reader.GetString(3);
                            string City = reader.GetString(4);
                            string Number = reader.GetString(7);
                            int ID = reader.GetInt32(0);
                            list.Add(new Contact(ID,Name,Lastname,Adress,City,Number));
                        }
                        return list;
                    }
                    else
                    {
                        Console.WriteLine("No Data found");
                        
                    }
                    return list;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return list;
            }
        }
        public void WriteToDataBase(List<Contact> list)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("spAddContactDetails", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    foreach(Contact contact in list)
                    {
                        //command.Parameters.AddWithValue("@ID", contact.ID);
                        command.Parameters.AddWithValue("@Name", contact.Name);
                        command.Parameters.AddWithValue("@LastName", contact.Lastname);
                        command.Parameters.AddWithValue("@Adress", contact.Adress);
                        command.Parameters.AddWithValue("@City",contact.City);
                        command.Parameters.AddWithValue("@Number", contact.Number);
                        connection.Open();
                        var result = command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        connection.Close();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
