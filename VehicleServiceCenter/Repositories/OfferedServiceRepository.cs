using System.Data;
using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class OfferedServiceRepository
    {

        public int InsertService(OfferedService service)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO OfferedServices (ServiceName, Description, Price, EstimatedDurationMinutes, CustomerID)
                                     VALUES (@ServiceName, @Description, @Price, @EstimatedDurationMinutes, @CustomerID)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ServiceName", service.ServiceName);
                        cmd.Parameters.AddWithValue("@Description", service.Description);
                        cmd.Parameters.AddWithValue("@Price", service.Price);
                        cmd.Parameters.AddWithValue("@EstimatedDurationMinutes", service.EstimatedDurationMinutes);
                        cmd.Parameters.AddWithValue("@CustomerID", service.CustomerID);
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


        public int UpdateService(OfferedService service)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE OfferedServices SET 
                                        ServiceName = @ServiceName,
                                        Description = @Description,
                                        Price = @Price,
                                        EstimatedDurationMinutes = @EstimatedDurationMinutes
                                     WHERE ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ServiceID", service.ServiceID);
                        cmd.Parameters.AddWithValue("@ServiceName", service.ServiceName);
                        cmd.Parameters.AddWithValue("@Description", service.Description);
                        cmd.Parameters.AddWithValue("@Price", service.Price);
                        cmd.Parameters.AddWithValue("@EstimatedDurationMinutes", service.EstimatedDurationMinutes);
                        cmd.Parameters.AddWithValue("@CustomerID", service.CustomerID);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int DeleteService(int serviceId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "DELETE FROM OfferedServices WHERE ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public List<OfferedService> GetAllServices()
        {
            List<OfferedService> services = new List<OfferedService>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM OfferedServices";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OfferedService os = new OfferedService();

                                os.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                                os.ServiceName = reader["ServiceName"].ToString();
                                os.Description = reader["Description"].ToString();
                                os.Price = Convert.ToDecimal(reader["Price"]);
                                os.EstimatedDurationMinutes = Convert.ToInt32(reader["EstimatedDurationMinutes"]);

                                services.Add(os);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return services;
        }

        public DataTable GetAllServicesAsDataTable() {
            DataTable dt = new DataTable();

            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT * FROM OfferedServices";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                            adapter.Fill(dt);
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("GetAllServicesAsDataTable Error: " + ex.Message);
            }

            return dt;
        }


        public OfferedService GetServiceById(int serviceId)
        {
            OfferedService service = null;
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM OfferedServices WHERE ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                service = new OfferedService();

                                service.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                                service.ServiceName = reader["ServiceName"].ToString();
                                service.Description = reader["Description"].ToString();
                                service.Price = Convert.ToDecimal(reader["Price"]);
                                service.EstimatedDurationMinutes = Convert.ToInt32(reader["EstimatedDurationMinutes"]);
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return service;
        }
        public List<string> GetServicesByCustomerId(int customerId)
        {
            List<string> serviceNames = new List<string>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    // Select only the ServiceName for the given CustomerID
                    string query = "SELECT ServiceName FROM OfferedServices WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Read the ServiceName from the current row and add it to the list
                                serviceNames.Add(reader["ServiceName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes.
                // In a real application, you might want more robust error handling (e.g., throwing a custom exception or logging to a file).
                Console.WriteLine($"Error in GetServicesByCustomerId: {ex.Message}");
                // Optionally re-throw the exception or return an empty list as per desired behavior.
            }
            return serviceNames;
        }

        public List<OfferedService> GetServicesByPrice(int price)
        {
            List<OfferedService> services = new List<OfferedService>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM OfferedServices WHERE Price <= @Price ORDER BY Price ASC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Price", price);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OfferedService service = new OfferedService();

                                service.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                                service.ServiceName = reader["ServiceName"].ToString();
                                service.Description = reader["Description"].ToString();
                                service.Price = Convert.ToDecimal(reader["Price"]);
                                service.EstimatedDurationMinutes = Convert.ToInt32(reader["EstimatedDurationMinutes"]);
                                
                                services.Add(service);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return services;
        }

        public DataTable GetServicesByPriceAsDataTable(int price) {
            DataTable dt = new DataTable();

            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT * FROM OfferedServices WHERE Price <= @Price ORDER BY Price ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@Price", price);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                            adapter.Fill(dt);
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("GetServicesByPriceAsDataTable Error: " + ex.Message);
            }

            return dt;
        }

    }
}
