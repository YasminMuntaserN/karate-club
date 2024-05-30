using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Karate_DataAccsess
{
    public class clsSubscriptionPeriodsData
    {
        public static bool GetSubscriptionPeriodByID(int? PeriodID, ref DateTime StartDate,
            ref DateTime EndDate, ref decimal Fees, ref bool IsPaid, ref int? MemberID, ref int? PaymentID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM SubscriptionPeriods WHERE PeriodID = @PeriodID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PeriodID", (object)PeriodID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;
                                StartDate = (DateTime)reader["StartDate"];
                                EndDate = (DateTime)reader["EndDate"];
                                Fees = (decimal)reader["Fees"];
                                IsPaid = (bool)reader["IsPaid"];
                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;
                                PaymentID = (reader["PaymentID"] != DBNull.Value) ? (int?)reader["PaymentID"] : null;
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

        public static bool GetSubscriptionPeriodByMemberID(int? MemberID, ref DateTime StartDate,
            ref DateTime EndDate, ref decimal Fees, ref bool IsPaid, ref int? PeriodID, ref int? PaymentID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM SubscriptionPeriods WHERE MemberID = @MemberID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;
                                StartDate = (DateTime)reader["StartDate"];
                                EndDate = (DateTime)reader["EndDate"];
                                Fees = (decimal)reader["Fees"];
                                IsPaid = (bool)reader["IsPaid"];
                                MemberID = (reader["PeriodID"] != DBNull.Value) ? (int?)reader["PeriodID"] : null;
                                PaymentID = (reader["PaymentID"] != DBNull.Value) ? (int?)reader["PaymentID"] : null;
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

        public static int? Add(DateTime StartDate,
             DateTime EndDate, decimal Fees, bool IsPaid, int? MemberID, int? PaymentID)
        {
            int? PeriodID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Insert Into SubscriptionPeriods(StartDate ,EndDate,Fees ,IsPaid ,MemberID,PaymentID)
                                 Values(@StartDate ,@EndDate,@Fees ,@IsPaid ,@MemberID,@PaymentID);
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
                        command.Parameters.AddWithValue("@Fees", Fees);
                        command.Parameters.AddWithValue("@IsPaid", IsPaid);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PeriodID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return PeriodID;
        }

        public static bool Update(int? PeriodID, DateTime StartDate,
             DateTime EndDate, decimal Fees, bool IsPaid, int? MemberID, int? PaymentID)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  SubscriptionPeriods  
                            set StartDate = @StartDate,
                                EndDate = @EndDate,
                                Fees = @Fees,
                                IsPaid = @IsPaid,
                                MemberID =@MemberID,
                                PaymentID =@PaymentID
                                where PeriodID = @PeriodID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PeriodID", (object)PeriodID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
                        command.Parameters.AddWithValue("@Fees", Fees);
                        command.Parameters.AddWithValue("@IsPaid", IsPaid);

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
            return clsDataAccessHelper.All("SELECT * FROM SubscriptionPeriodsInfo");
        }

        public static DataTable All(string MemberName)
        {
            return clsDataAccessHelper.All("SELECT * FROM SubscriptionPeriodsInfo WHERE MemberName = @MemberName", "MemberName", MemberName);
        }

        public static bool Delete(int? PeriodID)
        {
            return clsDataAccessHelper.Delete("Delete from SubscriptionPeriods where PeriodID =@PeriodID; ", "PeriodID", PeriodID);
        }

        public static bool Exist(int? PeriodID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from SubscriptionPeriods where PeriodID =@PeriodID", "PeriodID", PeriodID);
        }

        public static bool ExistWithMemberIDAndPeriodNotEnd(int? MemberID)
        {
            return clsDataAccessHelper.Exists("SELECT TOP 1* FROM SubscriptionPeriods WHERE MemberID = @MemberID AND CONVERT (DATE, EndDate) >= CONVERT (DATE, GETDATE () ) ORDER BY StartDate DESC", "MemberID", MemberID);
        }

        public static bool ExistWithPaymentID(int? PaymentID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from SubscriptionPeriods where PaymentID =@PaymentID", "PaymentID", PaymentID);
        }

        public static int Count()
        {
            return clsDataAccessHelper.Count(" select count(*) from SubscriptionPeriods;");
        }
    }
}
