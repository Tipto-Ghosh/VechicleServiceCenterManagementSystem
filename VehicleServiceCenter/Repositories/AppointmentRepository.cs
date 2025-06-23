using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class AppointmentRepository
    {

        public int CreateAppointment(Appointment appointment)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO Appointments 
                                     (CustomerID, MechanicID, ScheduledDate, Status, CreatedBy, TokenNumber)
                                     VALUES (@CustomerID, @MechanicID, @ScheduledDate, @Status, @CreatedBy, @TokenNumber)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", appointment.CustomerID);
                        cmd.Parameters.AddWithValue("@MechanicID", appointment.MechanicID);
                        cmd.Parameters.AddWithValue("@ScheduledDate", appointment.ScheduledDate);
                        cmd.Parameters.AddWithValue("@Status", appointment.Status);
                        cmd.Parameters.AddWithValue("@CreatedBy", appointment.CreatedBy);
                        cmd.Parameters.AddWithValue("@TokenNumber", appointment.TokenNumber);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateAppointment Error: " + ex.Message);
                return 0;
            }
        }

        public int UpdateAppointment(Appointment appointment)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE Appointments SET CustomerID = @CustomerID, MechanicID = @MechanicID,
                                        ScheduledDate = @ScheduledDate, Status = @Status, CreatedBy = @CreatedBy,
                                        TokenNumber = @TokenNumber WHERE AppointmentID = @AppointmentID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointment.AppointmentID);
                        cmd.Parameters.AddWithValue("@CustomerID", appointment.CustomerID);
                        cmd.Parameters.AddWithValue("@MechanicID", appointment.MechanicID);
                        cmd.Parameters.AddWithValue("@ScheduledDate", appointment.ScheduledDate);
                        cmd.Parameters.AddWithValue("@Status", appointment.Status);
                        cmd.Parameters.AddWithValue("@CreatedBy", appointment.CreatedBy);
                        cmd.Parameters.AddWithValue("@TokenNumber", appointment.TokenNumber);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateAppointment Error: " + ex.Message);
                return 0;
            }
        }

        public int CancelAppointment(int appointmentId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE Appointments SET Status = 'Cancelled' WHERE AppointmentID = @AppointmentID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CancelAppointment Error: " + ex.Message);
                return 0;
            }
        }

        public List<Appointment> GetAppointmentsByCustomerId(int customerId)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM Appointments WHERE CustomerID = @CustomerID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Appointment appointment = new Appointment();
                                appointment.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                                appointment.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                appointment.MechanicID = Convert.ToInt32(reader["MechanicID"]);
                                appointment.ScheduledDate = Convert.ToDateTime(reader["ScheduledDate"]);
                                appointment.Status = reader["Status"].ToString();
                                appointment.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                                appointment.TokenNumber = Convert.ToInt32(reader["TokenNumber"]);
                                appointments.Add(appointment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAppointmentsByCustomer Error: " + ex.Message);
            }
            return appointments;
        }

        public List<Appointment> GetAppointmentsByMechanicId(int mechanicId)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM Appointments WHERE MechanicID = @MechanicID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MechanicID", mechanicId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Appointment appointment = new Appointment();
                                appointment.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                                appointment.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                appointment.MechanicID = Convert.ToInt32(reader["MechanicID"]);
                                appointment.ScheduledDate = Convert.ToDateTime(reader["ScheduledDate"]);
                                appointment.Status = reader["Status"].ToString();
                                appointment.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                                appointment.TokenNumber = Convert.ToInt32(reader["TokenNumber"]);
                                appointments.Add(appointment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAppointmentsByMechanic Error: " + ex.Message);
            }
            return appointments;
        }

        public Appointment GetAppointmentById(int id)
        {
            Appointment appointment = null;
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM Appointments WHERE AppointmentID = @AppointmentID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", id);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                appointment = new Appointment();

                                appointment.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                                appointment.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                appointment.MechanicID = Convert.ToInt32(reader["MechanicID"]);
                                appointment.ScheduledDate = Convert.ToDateTime(reader["ScheduledDate"]);
                                appointment.Status = reader["Status"].ToString();
                                appointment.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                                appointment.TokenNumber = Convert.ToInt32(reader["TokenNumber"]);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAppointmentById Error: " + ex.Message);
                return appointment;
            }
            return appointment;
        }


        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM Appointments";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Appointment appointment = new Appointment();
                                appointment.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                                appointment.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                appointment.MechanicID = Convert.ToInt32(reader["MechanicID"]);
                                appointment.ScheduledDate = Convert.ToDateTime(reader["ScheduledDate"]);
                                appointment.Status = reader["Status"].ToString();
                                appointment.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                                appointment.TokenNumber = Convert.ToInt32(reader["TokenNumber"]);

                                appointments.Add(appointment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return appointments;
            }

            return appointments;
        }


        public int AssignMechanic(int appointmentId, int mechanicId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE Appointments SET MechanicID = @MechanicID
                                     WHERE AppointmentID = @AppointmentID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        cmd.Parameters.AddWithValue("@MechanicID", mechanicId);
                        conn.Open();

                        return cmd.ExecuteNonQuery() > 0 ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AssignMechanic Error: " + ex.Message);
                return 0;
            }
        }

        public List<Appointment> GetAssignedJobs(int mechanicId, string status)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM Appointments WHERE " +
                        "MechanicID = @MechanicID AND Status = @Status";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Status", status.ToLower());
                        cmd.Parameters.AddWithValue("@MechanicID", mechanicId);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Appointment appointment = new Appointment();
                                appointment.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                                appointment.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                appointment.MechanicID = Convert.ToInt32(reader["MechanicID"]);
                                appointment.ScheduledDate = Convert.ToDateTime(reader["ScheduledDate"]);
                                appointment.Status = reader["Status"].ToString();
                                appointment.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                                appointment.TokenNumber = Convert.ToInt32(reader["TokenNumber"]);

                                appointments.Add(appointment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return appointments;
            }

            return appointments;
        }
    }
}
