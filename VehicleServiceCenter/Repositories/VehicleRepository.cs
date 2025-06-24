using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class VehicleRepository
    {

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
