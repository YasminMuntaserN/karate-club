using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_DataAccsess
{
    public class clsBeltTestsData
    {
        public static bool GetBeltTestInfoByID(int? TestID, ref int? MemberID,
            ref int? RankID, ref bool Result, ref DateTime Date,
            ref int? InstructorID, ref int? PaymentID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BeltTests WHERE TestID = @TestID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TestID", (object)TestID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                PaymentID = (reader["PaymentID"] != DBNull.Value) ? (int?)reader["PaymentID"] : null;
                                RankID = (reader["RankID"] != DBNull.Value) ? (int?)reader["RankID"] : null;
                                InstructorID = (reader["InstructorID"] != DBNull.Value) ? (int?)reader["InstructorID"] : null;
                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;
                                Result = (bool)reader["Result"];
                                Date = (DateTime)reader["Date"];
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

        public static bool GetBeltTestInfoByMemberID(int? MemberID, ref int? TestID,
          ref int? RankID, ref bool Result, ref DateTime Date,
          ref int? InstructorID, ref int? PaymentID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BeltTests WHERE MemberID = @MemberID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                PaymentID = (reader["PaymentID"] != DBNull.Value) ? (int?)reader["PaymentID"] : null;
                                RankID = (reader["RankID"] != DBNull.Value) ? (int?)reader["RankID"] : null;
                                InstructorID = (reader["InstructorID"] != DBNull.Value) ? (int?)reader["InstructorID"] : null;
                                TestID = (reader["TestID"] != DBNull.Value) ? (int?)reader["TestID"] : null;
                                Result = (bool)reader["Result"];
                                Date = (DateTime)reader["Date"];
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

        public static int? Add(int? MemberID, int? RankID, bool Result,
            DateTime Date, int? InstructorID, int? PaymentID)
        {
            int? TestID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Insert Into BeltTests(MemberID ,PaymentID,RankID,InstructorID,Result,Date)
                                 Values(@MemberID,@PaymentID,@RankID,@InstructorID ,@Result,@Date);
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@InstructorID", (object)InstructorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Result", Result);
                        command.Parameters.AddWithValue("@Date", Date);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TestID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return TestID;
        }

        public static bool Update(int? TestID, int? MemberID, int? RankID,
            bool Result, DateTime Date, int? InstructorID, int? PaymentID)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  BeltTests  
                            set MemberID = @MemberID,
                                PaymentID = @PaymentID,
                                RankID = @RankID,
                                InstructorID = @InstructorID,
                                Result = @Result,
                                Date = @Date
                                where TestID = @TestID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestID", (object)TestID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@InstructorID", (object)InstructorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Result", Result);
                        command.Parameters.AddWithValue("@Date", Date);

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
            return clsDataAccessHelper.All("select * from BeltTestInfo ;");
        }

        public static DataTable All(string MemberName)
        {
            return clsDataAccessHelper.All("SELECT * FROM BeltTestInfo where MemberName =@MemberName; ", "MemberName", MemberName);
        }

        public static bool PassTest(int? RankID , int? MemberID)
        {
            return clsDataAccessHelper.Exists("Select IsFound =1 from BeltTests where RankID =@RankID and MemberID=@MemberID and Result= 1", "RankID", RankID
                , "MemberID", MemberID);
        }

        public static bool Exists(int?MemberID)
        {
            return clsDataAccessHelper.Exists("Select isFound = 1 from BeltTests where MemberID = @MemberID", "MemberID", MemberID);
        }

    }
}
