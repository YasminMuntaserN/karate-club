using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_DataAccsess
{
    public class clsPaymentsData
    {

        public static bool GetPaymentInfoByID(int? PaymentID, ref int? MemberID,ref decimal Amount ,ref DateTime Date)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Payments WHERE PaymentID = @PaymentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;
                                Amount = (decimal)reader["Amount"];
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
   
        public static bool GetPaymentInfoByMemberID(int? MemberID, ref int? PaymentID, ref decimal Amount ,ref DateTime Date)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Payments WHERE MemberID = @MemberID";
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
                                Amount = (decimal)reader["Amount"];
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

        public static int? Add(int? MemberID,decimal Amount,  DateTime Date)
        {
            int? PeriodID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Insert Into Payments(MemberID ,Amount,Date)
                                 Values(@MemberID ,@Amount,@Date);
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@Date", Date);

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

        public static bool Update(int? PaymentID, int? MemberID, decimal Amount, DateTime Date)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  Payments  
                            set MemberID = @MemberID,
                                Date = @Date,
                                Amount = @Amount
                                where PaymentID = @PaymentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Amount", Amount);

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
            return clsDataAccessHelper.All("SELECT * FROM PaymentsInfo ");
        }

        public static bool Delete(int? PaymentID)
        {
            return clsDataAccessHelper.Delete("Delete from Payments where PaymentID =@PaymentID; ", "PaymentID", PaymentID);
        }

        public static bool Exist(int? PaymentID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from Payments where PaymentID =@PaymentID", "PaymentID", PaymentID);
        }

        public static bool ExistByMemberID(int? MemberID)
        {
            return clsDataAccessHelper.Exists("select isFound =1 from Payments where MemberID =@MemberID", "MemberID", MemberID);
        }

        public static DataTable All(string MemberName)
        {
            return clsDataAccessHelper.All("SELECT * FROM PaymentsInfo where MemberName =@MemberName; ", "MemberName", MemberName);
        }

    }
}
