using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class VehicleRepository
    {
        public List<Vehicle> GetCustomerVehicles(int customerId)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"SELECT VehicleID, CustomerID, LicensePlate, Model
                                 FROM Vehicles
                                 WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Vehicle vehicle = new Vehicle
                                {
                                    VehicleID = reader.GetInt32(reader.GetOrdinal("VehicleID")),
                                    CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                    LicensePlate = reader.GetString(reader.GetOrdinal("LicensePlate")),
                                    Model = reader.IsDBNull(reader.GetOrdinal("Model")) ? null : reader.GetString(reader.GetOrdinal("Model"))
                                };
                                vehicles.Add(vehicle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCustomerVehicles: {ex.Message}");
                // Consider logging the full exception for debugging in a real application
            }
            return vehicles;
        }
        public int InsertVehicle(Vehicle vehicle)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO Vehicles (CustomerID, LicensePlate, Model)
                                     VALUES (@CustomerID, @LicensePlate, @Model)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", vehicle.CustomerID);
                        cmd.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                        cmd.Parameters.AddWithValue("@Model", vehicle.Model);

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

        public int UpdateVehicle(Vehicle vehicle)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE Vehicles SET CustomerID = @CustomerID, LicensePlate = @LicensePlate,
                    Model = @Model WHERE VehicleID = @VehicleID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);
                        cmd.Parameters.AddWithValue("@CustomerID", vehicle.CustomerID);
                        cmd.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                        cmd.Parameters.AddWithValue("@Model", vehicle.Model);

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

        public int DeleteVehicle(int vehicleId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleId);

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
