using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_DataAccsess
{
    public class clsMemberInstructorsData
    {
        public static bool GetMemberInstructorInfoByID(int? MemberInstructorID,
           ref int? MemberID, ref int? InstructorID, ref DateTime AssignDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select * from MemberInstructors where MemberInstructorID=@MemberInstructorID; ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberInstructorID", (object)MemberInstructorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;
                                InstructorID = (reader["InstructorID"] != DBNull.Value) ? (int?)reader["InstructorID"] : null;
                                AssignDate = (DateTime)reader["AssignDate"];
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

        public static int? AddNewMemberInstructor(int? MemberID, int? InstructorID,
            DateTime AssignDate)
        {
            int? MemberInstructorID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Insert Into MemberInstructors(MemberID ,InstructorID,AssignDate)
                                 Values(@MemberID ,@InstructorID,@AssignDate);
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@InstructorID", (object)InstructorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AssignDate", AssignDate);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            MemberInstructorID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return MemberInstructorID;
        }

        public static bool UpdateMemberInstructor(int? MemberInstructorID, int? MemberID,
               int? InstructorID, DateTime AssignDate)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  MemberInstructors  
                            set MemberID = @MemberID,
                                InstructorID = @InstructorID,
                                AssignDate = @AssignDate
                                where MemberInstructorID = @MemberInstructorID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberInstructorID", (object)MemberInstructorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@InstructorID", (object)InstructorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AssignDate", AssignDate);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return (RowAffected > 0);
        }

        public static bool DeleteMemberInstructor(int? MemberInstructorID)
        {
            return clsDataAccessHelper.Delete("Delete from MemberInstructors where MemberInstructorID =@MemberInstructorID;", "MemberInstructorID", MemberInstructorID);
        }

        public static bool Exist(int? MemberInstructorID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from MemberInstructors where MemberInstructorID =@MemberInstructorID", "MemberInstructorID", MemberInstructorID);
        }

        public static bool Exist(int? MemberID , int? InstructorID)
        {
            return clsDataAccessHelper.Exists("select isFound=1 from MemberInstructors where MemberID =@MemberID and InstructorID=@InstructorID;"
                , "MemberID", MemberID, "InstructorID", InstructorID);
        }


        public static DataTable All()
        {
            return clsDataAccessHelper.All("SELECT * FROM MemberInstructorInfo");
        }

        public static DataTable GetTrainedMembersByInstructor(int? InstructorID)
        {
            DataTable dtTrainedMembers = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = " select MemberInstructors.InstructorID, MembersInfo.MemberID,MembersInfo.Name ,MembersInfo.RankName ,MembersInfo.IsActive" +
                        " from MembersInfo Inner join MemberInstructors on MembersInfo.MemberID=MemberInstructors.MemberID where MemberInstructors.InstructorID=@InstructorID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@InstructorID", (object)InstructorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtTrainedMembers.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return dtTrainedMembers;
        }


    }
}
