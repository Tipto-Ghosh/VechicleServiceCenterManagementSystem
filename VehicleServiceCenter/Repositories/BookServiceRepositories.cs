using System;
using System.Data;
using System.Data.SqlClient;
using VehicleServiceCenter.Config;

namespace VehicleServiceCenter.Repositories {
    internal class BookServiceRepositories {
        public int AddService(int customerId, int serviceId, string serviceName, decimal price) {
            using (SqlConnection con = DbConfig.GetConnection()) {
                con.Open();

                // Step 1: Insert into BookedServices
                string insertQuery = @"INSERT INTO BookedServices (CustomerID, ServiceID, ServiceName) 
                                       VALUES (@CustomerID, @ServiceID, @ServiceName)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con)) {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                    cmd.Parameters.AddWithValue("@ServiceName", serviceName);

                    try {
                        cmd.ExecuteNonQuery();
                    } catch {
                        return 0; // Already exists or failed
                    }
                }

                // Step 2: Check if payment exists
                string checkQuery = "SELECT COUNT(*) FROM Payments WHERE CustomerID = @CustomerID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con)) {
                    checkCmd.Parameters.AddWithValue("@CustomerID", customerId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0) {
                        // Update payment
                        string updateQuery = "UPDATE Payments SET Amount = Amount + @Price WHERE CustomerID = @CustomerID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con)) {
                            updateCmd.Parameters.AddWithValue("@CustomerID", customerId);
                            updateCmd.Parameters.AddWithValue("@Price", price);
                            updateCmd.ExecuteNonQuery();
                        }
                    } else {
                        // Insert new payment
                        string insertPayment = "INSERT INTO Payments (CustomerID, Amount) VALUES (@CustomerID, @Price)";
                        using (SqlCommand insertCmd = new SqlCommand(insertPayment, con)) {
                            insertCmd.Parameters.AddWithValue("@CustomerID", customerId);
                            insertCmd.Parameters.AddWithValue("@Price", price);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                return 1;
            }
        }

        public int DeleteService(int customerId, int serviceId, decimal price) {
            using (SqlConnection con = DbConfig.GetConnection()) {
                con.Open();

                // Step 1: Delete from BookedServices
                string deleteQuery = @"DELETE FROM BookedServices 
                                       WHERE CustomerID = @CustomerID AND ServiceID = @ServiceID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con)) {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        return 0; // Nothing to delete
                }

                // Step 2: Update payment
                string updatePayment = @"UPDATE Payments 
                                         SET Amount = Amount - @Price 
                                         WHERE CustomerID = @CustomerID";
                using (SqlCommand updateCmd = new SqlCommand(updatePayment, con)) {
                    updateCmd.Parameters.AddWithValue("@CustomerID", customerId);
                    updateCmd.Parameters.AddWithValue("@Price", price);
                    updateCmd.ExecuteNonQuery();
                }

                return 1;
            }
        }

        public DataTable GetAllBookedServiceByCustomerId(int customerId) {
            DataTable dt = new DataTable();

            using (SqlConnection con = DbConfig.GetConnection()) {
                string query = "SELECT BookingID, ServiceID, ServiceName FROM BookedServices WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, con)) {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public List<Tuple<int, string>> GetBookedServiceList(int customerId) {
            List<Tuple<int, string>> serviceList = new List<Tuple<int, string>>();

            using (SqlConnection con = DbConfig.GetConnection()) {
                string query = "SELECT ServiceID, ServiceName FROM BookedServices WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, con)) {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            int serviceId = reader.GetInt32(0);
                            string serviceName = reader.GetString(1);
                            serviceList.Add(Tuple.Create(serviceId, serviceName));
                        }
                    }
                }
            }

            return serviceList;
        }

    }
}
