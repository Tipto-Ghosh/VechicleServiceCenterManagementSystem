using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class AppointmentServicesRepository
    {

        public AppointmentServicesRepository()
        {

        }
        public int AddServiceToAppointment(int appointmentId, int serviceId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO AppointmentServices (AppointmentID, ServiceID) VALUES (@AppointmentID, @ServiceID)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddServiceToAppointment Error: " + ex.Message);
                return 0;
            }
        }

        public int RemoveServiceFromAppointment(int appointmentId, int serviceId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"DELETE FROM AppointmentServices WHERE AppointmentID = @AppointmentID AND ServiceID = @ServiceID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("RemoveServiceFromAppointment Error: " + ex.Message);
                return 0;
            }
        }

        public List<OfferedService> GetServicesByAppointment(int appointmentId)
        {
            List<OfferedService> services = new List<OfferedService>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"
                        SELECT os.ServiceID, os.ServiceName, os.Description, os.Price, os.EstimatedDurationMinutes
                        FROM AppointmentServices aps JOIN OfferedServices os ON aps.ServiceID = os.ServiceID
                        WHERE aps.AppointmentID = @AppointmentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OfferedService service = new OfferedService
                                {
                                    ServiceID = Convert.ToInt32(reader["ServiceID"]),
                                    ServiceName = reader["ServiceName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    EstimatedDurationMinutes = Convert.ToInt32(reader["EstimatedDurationMinutes"])
                                };
                                services.Add(service);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetServicesByAppointment Error: " + ex.Message);
            }
            return services;
        }

        public int AddMultipleServicesToAppointment(int appointmentId, List<int> serviceIds)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        foreach (int serviceId in serviceIds)
                        {
                            string query = @"INSERT INTO AppointmentServices (AppointmentID, ServiceID)
                                     VALUES (@AppointmentID, @ServiceID)";
                            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                                cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                                int result = cmd.ExecuteNonQuery();
                                if (result == 0)
                                {
                                    transaction.Rollback();
                                    return 0;
                                }
                            }
                        }
                        transaction.Commit();
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddMultipleServicesToAppointment Error: " + ex.Message);
                return 0;
            }
        }

    }
}
