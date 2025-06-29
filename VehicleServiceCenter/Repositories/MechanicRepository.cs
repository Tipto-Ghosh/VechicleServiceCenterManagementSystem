using System.Data;
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

        public int UpdateMechanic(Mechanic mech) {
            try {
                // First update the Users table
                UserRepository userRepo = new UserRepository();
                int userStatus = userRepo.UpdateUser(mech);

                Console.WriteLine("UpdateUser affected rows: " + userStatus);

                // If user not found or update failed
                if (userStatus <= 0)
                    return userStatus; // -1 or 0

                // Now update the Mechanics table
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"UPDATE Mechanics 
                             SET Rating = @Rating, Status = @Status 
                             WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@Rating", mech.Rating);
                        cmd.Parameters.AddWithValue("@Status", mech.Status ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@UserID", mech.UserID);

                        conn.Open();
                        int mechRows = cmd.ExecuteNonQuery();

                        // Return 1 only if both updates succeed
                        return mechRows > 0 ? 1 : 0;
                    }
                }
            } catch (Exception ex) {
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

        public DataTable GetMechanicJobsAsDataTable(int mechId) {
            DataTable dt = new DataTable();

            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"SELECT AppointmentID, ScheduledDate FROM Appointments WHERE MechanicID = @MechID";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@MechID", mechId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                            adapter.Fill(dt);
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("GetMechanicJobsAsDataTable Error: " + ex.Message);
            }

            return dt;
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

        public int GetMechanicCount() {
            int count = 0;


            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {

                    string q = @"SELECT COUNT(*) FROM Users WHERE LOWER(UserType) = 'mechanic'";

                    using (SqlCommand cmd = new SqlCommand(q, conn)) {
                        conn.Open();
                        count = (int)cmd.ExecuteScalar();
                    }

                }
            } catch (Exception ex) {
                Console.WriteLine("GetCustomerCount Error " + ex.Message);
            }

            return count;
        }
        public DataTable GetAllMechanicsAsDataTable() {
            DataTable dt = new DataTable(); 

            try {
               
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    
                    string query = @"SELECT U.UserID, U.Name, U.Password, U.Gender, U.DateOfBirth, U.BloodGroup, U.Email,
                                        M.Rating, M.Status FROM Users U
                                       INNER JOIN Mechanics M ON U.UserID = M.UserID
                                       WHERE LOWER(U.UserType) = 'mechanic'";

                    
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                       
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                            adapter.Fill(dt); 
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("GetAllMechanicDataTable Error: " + ex.Message);
                return dt;
            }

            return dt; 
        }
    }
}
