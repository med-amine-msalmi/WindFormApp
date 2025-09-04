
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContactDataAccess
{
    public class CountryData
    {

        public static int findCountryByName(string countryName,ref string code,ref string phoneCode)
        {

            int CountryId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select*from Countries where CountryName=@countryName";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@countryName", countryName);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    CountryId = (int)reader["CountryID"];
                    code = reader["Code"].ToString();
                    phoneCode = reader["PhoneCode"].ToString() ;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return CountryId;
        }
        public static bool findById(int id,ref string countryName,ref string code ,ref string phoneCode)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select*from Countries where CountryID=@id";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", id);
            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    countryName = reader["CountryName"].ToString();
                    code = reader["Code"].ToString();
                    phoneCode = reader["phoneCode"].ToString();
                    
                }

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
        public static int addNewCountry(string countryName,string code,string phoneCode)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "insert into Countries(CountryName,Code,PhoneCode) values(@countryName,@code,@phoneCode)" +
                "select Scope_Identity(); ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@countryName", countryName);
            if(code !="")
                command.Parameters.AddWithValue("@code", code);
            else 
                command.Parameters.AddWithValue("@code",DBNull.Value);
            if (phoneCode != "")
                command.Parameters.AddWithValue("@phoneCode", phoneCode);
            else
                command.Parameters.AddWithValue("@phoneCode", DBNull.Value);    
            int insertedId = -1;
            try
            {
                connection.Open();
                 object result = command.ExecuteScalar();
                if (result !=null && int.TryParse(result.ToString(),out int id))
                {
                   insertedId = id;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            finally
            {
                connection.Close();
            }


            return insertedId;
        }

        public static bool updateCountry(int id,string countryName,string code,string phoneCode)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "update Countries " +
                "          set CountryName=@countryName," +
                "              Code=@code ," +
                "              PhoneCode=@phoneCode" + 
                "          where CountryID=@id ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@countryName", countryName);
            if (code != "")
                command.Parameters.AddWithValue("@code", code);
            else
                command.Parameters.AddWithValue("@code", DBNull.Value);
            if (phoneCode != "")
                command.Parameters.AddWithValue("@phoneCode", phoneCode);
            else
                command.Parameters.AddWithValue("@phoneCode", DBNull.Value);
            int Rows = 0;
            try
            {
                connection.Open();
                Rows = (int)command.ExecuteNonQuery();
            }catch(SqlException ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            return Rows>0;
        }
        public static bool isExist(string countryName)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select CountryID from Countries where CountryName=@countryName";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@countryName", countryName);
            bool isFound = false;
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                    isFound = true;


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return isFound;

        }
        public static DataTable getAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select*from Countries";
            SqlCommand cmd = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }



            return dt;
        }

    }
}
