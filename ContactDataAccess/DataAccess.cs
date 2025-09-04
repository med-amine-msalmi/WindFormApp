using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDataAccess
{
    public class DataAccess
    {
        public static bool GetContactInfoByID(int ID, ref string FirstName, ref string LastName,
            ref string Email, ref string Phone, ref string Address,
            ref DateTime DateOfBirth, ref string ImagePath, ref int CountryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["CountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = reader["ImagePath"].ToString();
                    }
                    else
                    { ImagePath = ""; }
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddContact(string FirstName, string LastName, string Email, string PhoneNumber, string Address, DateTime DateOfBirth, string ImagePath, int CountryId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "insert into Contacts(FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath) values(@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth,@CountryID,@ImagePath);" +
                "select Scope_Identity(); ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", PhoneNumber);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryId);
            if (ImagePath == "")
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else { command.Parameters.AddWithValue("@ImagePath",ImagePath); }
            // the function return the ID of inserted row else -1
            int insertedID = -1;
                try
                {   
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result !=null && int.TryParse(result.ToString(),out int id))
                    {
                        insertedID = id;
                    }
                }
                catch (SqlException ex)
                {

                    Console.WriteLine($"Error {ex.Message}");

                }
                finally
                {
                    connection.Close();
                }

            return insertedID;
        }
        public static bool UpdateContact(int Id,string FirstName, string LastName, string Email, string PhoneNumber, string Address, DateTime DateOfBirth, string ImagePath, int CountryId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "update Contacts set FirstName=@FirstName , LastName=@LastName , Email=@Email," +
                "Phone=@PhoneNumber , DateOfBirth=@DateOfBirth , Address=@Address,ImagePath=@ImagePath, CountryID=@CountryID " +
                "where ContactID=@ID ;";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PhoneNumber",PhoneNumber);
            command.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@CountryID", CountryId);
            if (ImagePath == "")
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else { command.Parameters.AddWithValue("@ImagePath", ImagePath); }
            command.Parameters.AddWithValue("@ID", Id);
            bool isUpdated = false;
            try
            {
                connection.Open();
                int Row = command.ExecuteNonQuery();
                isUpdated= (Row == 1);

            }catch(SqlException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }
        public static bool Delete(int Id)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete from Contacts where ContactID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", Id);
            int Rows = 0;
            try
            {
                connection.Open();
                Rows=command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return Rows > 0;
        }

        public static DataTable getAllContacts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select*from Contacts";
            SqlCommand cmd = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader=cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch(SqlException ex) 
            {
                Console.WriteLine($"Error : {ex.Message}");  
            }
            finally
            {
                connection.Close();
            }



            return dt;
        }

        public static bool isExist(int id)
        {
           
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select ContactID from Contacts where ContactID=@Id";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("Id", id);
            bool isFound = false;
            try
            {
                connection.Open();
                object result=cmd.ExecuteScalar();
                if(result != null) 
                    isFound= true;
               
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message );
            }
            finally { connection.Close(); }

            return isFound;

        }
        
    }
}
