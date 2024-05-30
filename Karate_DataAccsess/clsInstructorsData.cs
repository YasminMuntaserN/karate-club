using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Karate_DataAccsess
{
    public class clsInstructorsData
    {
        public static bool GetInstructorInfoByID(int? InstructorID, ref int? PersonID, ref string Qualification)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Instructors WHERE InstructorID = @InstructorID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@InstructorID", (object)InstructorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                PersonID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                Qualification = (reader["Qualification"] != DBNull.Value) ? (string)reader["Qualification"] : "";
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

        public static bool GetMemberInfoByPersonID(int? PersonID, ref int? InstructorID, ref string Qualification)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Instructors WHERE PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                InstructorID = (reader["InstructorID"] != DBNull.Value) ? (int?)reader["InstructorID"] : null;
                                Qualification = (reader["Qualification"] != DBNull.Value) ? (string)reader["Qualification"] : "";

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

        public static int? Add(int? PersonID, string Qualification)
        {
            int? InstructorID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Insert Into Instructors(PersonID ,Qualification)
                                 Values(@PersonID ,@Qualification);
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        if (Qualification != "" && Qualification != null)
                            command.Parameters.AddWithValue("@Qualification", Qualification);
                        else
                            command.Parameters.AddWithValue("@Qualification", System.DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            InstructorID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return InstructorID;
        }

        public static bool Update( int? InstructorID,int? PersonID, string Qualification)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  Instructors  
                            set PersonID = @PersonID,
                                Qualification = @Qualification
                                where InstructorID = @InstructorID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InstructorID", (object)InstructorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);
                        if (Qualification != "" && Qualification != null)
                            command.Parameters.AddWithValue("@Qualification", Qualification);
                        else
                            command.Parameters.AddWithValue("@Qualification", System.DBNull.Value);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return (RowAffected > 0);
        }

        public static DataTable All()
        {
            return clsDataAccessHelper.All("SELECT * FROM InstructorsInfo ");
        }

        public static bool Delete(int? InstructorID)
        {
            return clsDataAccessHelper.Delete("Delete from Instructors where InstructorID =@InstructorID; ", "InstructorID", InstructorID);
        }

        public static bool Exist(int? InstructorID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from Instructors where InstructorID =@InstructorID", "InstructorID", InstructorID);
        }

        public static bool ExistWithPersonID(int? PersonID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from Instructors where PersonID =@PersonID", "PersonID", PersonID);
        }

        public static int Count()
        {
            return clsDataAccessHelper.Count(" select count(*) from Instructors;");
        }
    }
}
