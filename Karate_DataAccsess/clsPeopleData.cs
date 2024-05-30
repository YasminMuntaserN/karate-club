using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_DataAccsess
{
    public class clsPeopleData
    {
        public static bool GetPersonInfoByID(int? PersonID, ref string Name, ref DateTime DateOfBirth,
         ref short Gender, ref string Address, ref string Phone, ref string Email, ref string ImagePath)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM People WHERE PersonID = @PersonID" +
                        "" +
                        "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;
                                Name = (string)reader["Name"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Email = (string)reader["Email"];
                                Phone = (string)reader["Phone"];
                                //Email: allows null in database so we should handle null
                                if (reader["Address"] != DBNull.Value)
                                {
                                    Address = (string)reader["Address"];
                                }
                                else
                                {
                                    Address = "";
                                }
                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
                                }
                            }
                            else
                            {
                                // The record was not found
                                IsFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            return IsFound;
        }

        public static bool GetPersonInfoByName(string Name, ref int? PersonID, ref DateTime DateOfBirth,
         ref short Gender, ref string Address, ref string Phone, ref string Email, ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM People WHERE Name = @Name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Name", Name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;
                                PersonID = (int)reader["PersonID"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Email = (string)reader["Email"];
                                Phone = (string)reader["Phone"];
                                //Email: allows null in database so we should handle null
                                if (reader["Address"] != DBNull.Value)
                                {
                                    Address = (string)reader["Address"];
                                }
                                else
                                {
                                    Address = "";
                                }
                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
                                }
                            }
                            else
                            {
                                // The record was not found
                                IsFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            return IsFound;
        }

        public static int? AddNewPerson(string Name, DateTime DateOfBirth,
           short Gender, string Address, string Phone, string Email, string ImagePath)
        {
            int? PersonID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open(); 
                    string query = @"INSERT INTO People (Name,DateOfBirth,Gender,Address,Phone, Email,ImagePath)
                             VALUES (@Name,  @DateOfBirth,@Gender,@Address,@Phone, @Email,@ImagePath);
                             SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        if (Address != "" && Address != null)
                            command.Parameters.AddWithValue("@Address", Address);
                        else
                            command.Parameters.AddWithValue("@Address", System.DBNull.Value);
                        if (ImagePath != "")
                        {
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
                        }

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PersonID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return PersonID;
        }

        public static bool UpdatePerson(int? PersonID, string Name, DateTime DateOfBirth,
           short Gender, string Address, string Phone, string Email, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                            set Name = @Name,
                                DateOfBirth = @DateOfBirth,
                                Gender=@Gender,
                                Address = @Address,  
                                Phone = @Phone,
                                Email = @Email ,
                                ImagePath = @ImagePath 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Address != "" && Address != null)
                command.Parameters.AddWithValue("@Address", Address);
            else
                command.Parameters.AddWithValue("@Address", System.DBNull.Value);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllPeople()
        {

            return clsDataAccessHelper.All("Select * from People ;");
        }

        public static bool DeletePerson(int? PersonID)
        {
            return clsDataAccessHelper.Delete(@"Delete People where PersonID = @PersonID", "PersonID", PersonID);
        }

        public static bool IsPersonExist(int? PersonID)
        {
            return clsDataAccessHelper.Exists("Select isFound =1 from People where PersonID =PersonID ", "PersonID", PersonID);
        }

        public static bool IsPersonExist(string Name)
        {
            return clsDataAccessHelper.Exists("Select isFound =1 from People where Name =Name ", "Name", Name);
        }

    }
}
