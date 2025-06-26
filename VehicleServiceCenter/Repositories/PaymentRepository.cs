using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class PaymentRepository
    {

        public int InsertPayment(Payment payment)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO Payments (CustomerID, Amount, PaymentDate, PaymentMethod, Description) VALUES (@CustomerID, @Amount, @PaymentDate, @PaymentMethod, @Description)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", payment.CustomerID);
                    cmd.Parameters.AddWithValue("@Amount", payment.Amount);
                    cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                    // select null if not givet
                    cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod ?? (object)DBNull.Value);
                    // select null if not given
                    cmd.Parameters.AddWithValue("@Description", payment.Description ?? (object)DBNull.Value);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    return rows;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("InsertPayment Error: " + ex.Message);
                return 0;
            }
        }

        public List<Payment> GetPaymentsByCustomer(int customerId)
        {
            List<Payment> payments = new List<Payment>();

            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"SELECT * FROM Payments WHERE CustomerID = @CustomerID ORDER BY PaymentDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Payment payment = new Payment();
                            payment.PaymentID = Convert.ToInt32(reader["PaymentID"]);
                            payment.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            payment.Amount = Convert.ToDecimal(reader["Amount"]);
                            payment.PaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                            payment.PaymentMethod = reader["PaymentMethod"].ToString();
                            payment.Description = reader["Description"].ToString();
                            payments.Add(payment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetPaymentsByCustomer Error: " + ex.Message);
            }

            return payments;
        }

        public decimal GetTotalPaidByCustomer(int customerId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"SELECT ISNULL(SUM(Amount), 0) FROM Payments WHERE CustomerID = @CustomerID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    decimal amountPaind = result != null ? Convert.ToDecimal(result) : 0;
                    return amountPaind;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetTotalPaidByCustomer Error: " + ex.Message);
                return 0;
            }
        }
    }
}
