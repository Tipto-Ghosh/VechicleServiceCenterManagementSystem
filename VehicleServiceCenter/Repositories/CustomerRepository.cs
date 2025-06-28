using System.Data;
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

        public DataTable GetCustomerVehiclesAsDataTable(int customerId) {
            DataTable table = new DataTable();

            try {
                using(SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT VehicleID, CustomerID, LicensePlate, Model FROM Vehicles WHERE CustomerID = @CustomerID";
                    
                    using(SqlCommand cmd = new SqlCommand(query , conn)) {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        using(SqlDataAdapter ad = new SqlDataAdapter(cmd)) {
                            ad.Fill(table);
                        }
                    }
                }
            }catch(Exception ex) {
                Console.WriteLine("GetCustomerVehiclesAsDataTable Error " + ex.Message);
            }
            return table;
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


        public DataTable GetAllCustomerAsDataTable() {
            DataTable table = new DataTable();

            try {
                using (SqlConnection con = DbConfig.GetConnection()) {
                    string q = @"SELECT U.UserID,U.Password,U.Name,U.Gender,U.DateOfBirth,U.BloodGroup,U.Email,c.PhoneNumber
                             FROM Users U INNER JOIN Customers C ON U.UserID = C.UserID
                             WHERE U.UserType = 'customer'";

                    using (SqlCommand cmd = new SqlCommand(q, con)) {
                         using(SqlDataAdapter ad = new SqlDataAdapter(cmd)) {
                            ad.Fill(table);
                        }
                    }
                } 
            } catch (Exception ex) { 
                Console.WriteLine("GetAllCustomerAsDataTable Error " + ex.Message);
            }
            return table;
        }

        public int GetCustomerCount() {
            int count = 0;


            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {

                    string q = @"SELECT COUNT(*) FROM Users WHERE LOWER(UserType) = 'customer'";

                    using(SqlCommand cmd = new SqlCommand(q , conn)) {
                        conn.Open();
                        count = (int)cmd.ExecuteScalar();
                    }
                
                }
            }catch(Exception ex) {
                Console.WriteLine("GetCustomerCount Error " + ex.Message);
            }

            return count;
        }

        public string GetCustomerPhoneByID(int id) {
            string phoneNumber = null;

            string query = "SELECT PhoneNumber FROM Customers WHERE UserID = @UserID";

            using (SqlConnection con = DbConfig.GetConnection()) {
                using (SqlCommand cmd = new SqlCommand(query, con)) {
                    cmd.Parameters.AddWithValue("@UserID", id);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value) {
                        phoneNumber = result.ToString();
                    }
                }
            }

            return phoneNumber;
        }
    }
}
