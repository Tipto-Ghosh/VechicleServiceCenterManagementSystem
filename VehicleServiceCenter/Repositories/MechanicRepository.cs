using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class MechanicRepository
    {
        private string connString = DbConfig.connectionString;

        public int InsertMechanic(Mechanic mech)
        {
            try
            {
                UserRepository userRepository = new UserRepository();

                // Insert the User First
                int newUserId = userRepository.InsertUser(mech);

                if (newUserId == 0 || newUserId == -1)
                {
                    // User exists or Some other issue failed
                    return newUserId;
                }

                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO Mechanics (UserID, Rating, Status) VALUES (@UserID, @Rating, @Status)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", newUserId);
                    cmd.Parameters.AddWithValue("@Rating", mech.Rating);
                    cmd.Parameters.AddWithValue("@Status", mech.Status ?? (object)DBNull.Value); // If form send null then save null in database

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0 ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("InsertMechanic Error: " + ex.Message);
                return 0;
            }
        }

        public int UpdateMechanic(Mechanic mech)
        {
            try
            {
                UserRepository userRepository = new UserRepository();
                // Update the User first
                int userResult = userRepository.UpdateUser(mech);

                // if user update failed
                if (userResult != 1) return 0;

                // Now update Mechanic
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE Mechanics SET Rating = @Rating, Status = @Status WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Rating", mech.Rating);
                    cmd.Parameters.AddWithValue("@Status", mech.Status ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UserID", mech.UserID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0 ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateMechanic Error: " + ex.Message);
                return 0;
            }
        }

        public int DeleteMechanic(int mechId)
        {
            try
            {
                UserRepository userRepository = new UserRepository();
                return userRepository.DeleteUser(mechId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteMechanic Error: " + ex.Message);
                return 0;
            }
        }


        // Find all the jobs assigned to a specific Mechanic
        public List<string> GetMechanicJobs(int mechId)
        {
            List<string> jobs = new List<string>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"SELECT a.AppointmentID, a.ScheduledDate FROM Appointments a WHERE a.MechanicID = @MechID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MechID", mechId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string info = $"Appointment ID: {reader["AppointmentID"]}, Scheduled: {reader["ScheduledDate"]}";
                        jobs.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetMechanicJobs Error: " + ex.Message);
            }
            return jobs;
        }

        public bool UpdateAvailabilityStatus(int mechId, string status)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "UPDATE Mechanics SET Status = @Status WHERE UserID = @MechID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@MechID", mechId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateAvailabilityStatus Error: " + ex.Message);
                return false;
            }
        }
    }
}
