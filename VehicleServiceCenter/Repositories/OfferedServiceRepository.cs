using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories {
    public class OfferedServiceRepository {

        public int InsertService(OfferedService service) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"INSERT INTO OfferedServices (ServiceName, Description, Price, EstimatedDurationMinutes)
                                     VALUES (@ServiceName, @Description, @Price, @EstimatedDurationMinutes)";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@ServiceName", service.ServiceName);
                        cmd.Parameters.AddWithValue("@Description", service.Description);
                        cmd.Parameters.AddWithValue("@Price", service.Price);
                        cmd.Parameters.AddWithValue("@EstimatedDurationMinutes", service.EstimatedDurationMinutes);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


        public int UpdateService(OfferedService service) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"UPDATE OfferedServices SET 
                                        ServiceName = @ServiceName,
                                        Description = @Description,
                                        Price = @Price,
                                        EstimatedDurationMinutes = @EstimatedDurationMinutes
                                     WHERE ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@ServiceID", service.ServiceID);
                        cmd.Parameters.AddWithValue("@ServiceName", service.ServiceName);
                        cmd.Parameters.AddWithValue("@Description", service.Description);
                        cmd.Parameters.AddWithValue("@Price", service.Price);
                        cmd.Parameters.AddWithValue("@EstimatedDurationMinutes", service.EstimatedDurationMinutes);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int DeleteService(int serviceId) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "DELETE FROM OfferedServices WHERE ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public List<OfferedService> GetAllServices() {
            List<OfferedService> services = new List<OfferedService>();
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT * FROM OfferedServices";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                services.Add(new OfferedService {
                                    ServiceID = Convert.ToInt32(reader["ServiceID"]),
                                    ServiceName = reader["ServiceName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    EstimatedDurationMinutes = Convert.ToInt32(reader["EstimatedDurationMinutes"])
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return services;
        }


        public OfferedService GetServiceById(int serviceId) {
            OfferedService service = null;
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT * FROM OfferedServices WHERE ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                service = new OfferedService {
                                    ServiceID = Convert.ToInt32(reader["ServiceID"]),
                                    ServiceName = reader["ServiceName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    EstimatedDurationMinutes = Convert.ToInt32(reader["EstimatedDurationMinutes"])
                                };
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return service;
        }

        public List<OfferedService> GetServicesByPrice(int price) {
            List<OfferedService> services = new List<OfferedService>();
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT * FROM OfferedServices WHERE Price <= @Price ORDER BY Price ASC";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@Price", price);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                services.Add(new OfferedService {
                                    ServiceID = Convert.ToInt32(reader["ServiceID"]),
                                    ServiceName = reader["ServiceName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    EstimatedDurationMinutes = Convert.ToInt32(reader["EstimatedDurationMinutes"])
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return services;
        }
    }
}
