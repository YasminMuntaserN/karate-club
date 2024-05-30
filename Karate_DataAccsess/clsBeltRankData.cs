using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_DataAccsess
{
    public class clsBeltRankData
    {
        public static bool GetRankInfoByID(int? RankID, ref string RankName, ref decimal TestFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BeltRanks WHERE RankID = @RankID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                RankName = (string)reader["RankName"];
                                TestFees = (decimal)reader["TestFees"];
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

        public static bool GetRankInfoByName(string RankName, ref int? RankID, ref decimal TestFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BeltRanks WHERE RankName = @RankName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@RankName", (object)RankName ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                RankID = (int)reader["RankID"];
                                TestFees = (decimal)reader["TestFees"];
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

        public static bool UpdateRank(int? RankID, string RankName, decimal TestFees)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update BeltRanks set RankName =@RankName
                          ,TestFees=@TestFees where RankID =@RankID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@RankName", RankName);
                        command.Parameters.AddWithValue("@TestFees", TestFees);

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
            return clsDataAccessHelper.All("Select * from BeltRanks;");
        }

        public static int? GetNextBeltRankID(int? RankID)
        {
            int? NextRankID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = " SELECT Top 1* FROM BeltRanks WHERE RankID >@RankID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RankID", (object)RankID ?? DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertID))
                        {
                            NextRankID = insertID;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
            }

            return NextRankID;
        }

        public static int Count()
        {
            return clsDataAccessHelper.Count(" select count(*) from BeltRanks;");
        }

    }
}
