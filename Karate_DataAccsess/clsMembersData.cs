using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_DataAccsess
{
    public class clsMembersData
    {
        public static bool GetMemberInfoByID(int? MemberID, ref int? PersonID,
        ref string EmergencyContactInfo, ref int? RankID, ref bool IsActive)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Members WHERE MemberID = @MemberID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                PersonID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                EmergencyContactInfo = (string)reader["EmergencyContactInfo"];
                                RankID = (reader["RankID"] != DBNull.Value) ? (int?)reader["RankID"] : null;
                                IsActive = (bool)reader["IsActive"];
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

        public static bool GetMemberInfoByPersonID(int? PersonID, ref int? MemberID,
          ref string EmergencyContactInfo, ref int? RankID, ref bool IsActive)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Members WHERE PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;
                                EmergencyContactInfo = (string)reader["EmergencyContactInfo"];
                                RankID = (reader["RankID"] != DBNull.Value) ? (int?)reader["RankID"] : null;
                                IsActive = (bool)reader["IsActive"];
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

        public static int? Add(int? PersonID,
         string EmergencyContactInfo, int? RankID, bool IsActive)
        {
            int? MemberID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Insert Into Members(PersonID ,EmergencyContactInfo ,RankID ,IsActive )
                                 Values(@PersonID ,@EmergencyContactInfo ,@RankID ,@IsActive);
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EmergencyContactInfo", EmergencyContactInfo);
                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            MemberID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return MemberID;
        }

        public static bool Update(int? MemberID, int? PersonID,
           string EmergencyContactInfo, int? RankID, bool IsActive)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  Members  
                            set PersonID = @PersonID,
                                EmergencyContactInfo = @EmergencyContactInfo,
                                RankID = @RankID,
                                IsActive = @IsActive
                                where MemberID = @MemberID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@EmergencyContactInfo", EmergencyContactInfo);


                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return (RowAffected > 0);
        }

        public static bool UpdateRankID(int? MemberID, int? RankID)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  Members  
                            set 
                                RankID = @RankID
                                where MemberID = @MemberID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);
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
            return clsDataAccessHelper.All("SELECT * FROM MembersInfo ");
        }

        public static bool Delete(int? MemberID)
        {
            return clsDataAccessHelper.Delete("Delete from Members where MemberID =@MemberID; ", "MemberID", MemberID);
        }

        public static bool Exist(int? MemberID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from Members where MemberID =@MemberID", "MemberID", MemberID);
        }

        public static bool ExistWithPersonID(int? PersonID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from Members where PersonID =@PersonID", "PersonID", PersonID);
        }

        public static int Count()
        {
            return clsDataAccessHelper.Count(" select count(*) from Members;");
        }

    }
}
