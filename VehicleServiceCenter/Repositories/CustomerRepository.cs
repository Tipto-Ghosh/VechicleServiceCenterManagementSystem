using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class CustomerRepository
    {

        public int InsertCustomer(Customer customer)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                int newId = userRepo.InsertUser(customer);

                if (newId == 0 || newId == -1)
                {
                    return newId;
                }

                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "INSERT INTO Customers (UserID, PhoneNumber) VALUES (@UserID, @PhoneNumber)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", newId);
                        cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return newId;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int UpdateCustomer(Customer customer)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                int isUpdated = userRepo.UpdateUser(customer);

                if (isUpdated == 0 || isUpdated == -1)
                {
                    return isUpdated;
                }

                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "UPDATE Customers SET PhoneNumber = @PhoneNumber WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@UserID", customer.UserID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int DeleteCustomer(int id)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "DELETE FROM Customers WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", id);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public List<Vehicle> GetCustomerVehicles(int customerId)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT VehicleID, CustomerID, LicensePlate, Model FROM Vehicles WHERE CustomerID = @CustomerID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Vehicle vehicle = new Vehicle();
                                vehicle.VehicleID = Convert.ToInt32(reader["VehicleID"]);
                                vehicle.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                vehicle.LicensePlate = reader["LicensePlate"].ToString();
                                vehicle.Model = reader["Model"].ToString();
                                vehicles.Add(vehicle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return vehicles;
        }

        public int UpdatePhoneNumber(int customerId, string newPhoneNumber)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "UPDATE Customers SET PhoneNumber = @PhoneNumber WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                        cmd.Parameters.AddWithValue("@UserID", customerId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
