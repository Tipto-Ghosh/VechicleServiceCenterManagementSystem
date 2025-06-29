using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;

namespace VehicleServiceCenter.Repositories {
    public class DataAccess {
        public DataTable GetAllMechanicDataTable() {
            DataTable dt = new DataTable();
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"SELECT
                                        U.UserID, U.Name, U.Password, U.Gender, U.DateOfBirth, U.BloodGroup, U.Email,
                                        M.Rating, M.Status
                                    FROM Users U
                                    INNER JOIN Mechanics M ON U.UserID = M.UserID
                                    WHERE LOWER(U.UserType) = 'mechanic'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                        adapter.Fill(dt);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("GetAllMechanicDataTable Error: " + ex.Message);
            }
            return dt;
        }

        public bool AddNewMechanic(int userId, string name, string gender, string password, DateTime dob, string bloodGroup, string email, float rating, string status) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    conn.Open();

                    
                    string insertUserQuery = @"INSERT INTO Users (UserID, Name, Gender, Password, DateOfBirth, BloodGroup, Email, UserType)
                                       VALUES (@UserID, @Name, @Gender, @Password, @DateOfBirth, @BloodGroup, @Email, 'Mechanic')";

                    SqlCommand cmdUser = new SqlCommand(insertUserQuery, conn);
                    cmdUser.Parameters.AddWithValue("@UserID", userId);
                    cmdUser.Parameters.AddWithValue("@Name", name);
                    cmdUser.Parameters.AddWithValue("@Gender", gender ?? (object)DBNull.Value);
                    cmdUser.Parameters.AddWithValue("@Password", password);
                    cmdUser.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmdUser.Parameters.AddWithValue("@BloodGroup", bloodGroup ?? (object)DBNull.Value);
                    cmdUser.Parameters.AddWithValue("@Email", email);

                    int userRows = cmdUser.ExecuteNonQuery();
                    if (userRows <= 0) return false;

                    
                    string insertMechanicQuery = @"INSERT INTO Mechanics (UserID, Rating, Status)
                                           VALUES (@UserID, @Rating, @Status)";
                    SqlCommand cmdMech = new SqlCommand(insertMechanicQuery, conn);
                    cmdMech.Parameters.AddWithValue("@UserID", userId);
                    cmdMech.Parameters.AddWithValue("@Rating", rating);
                    cmdMech.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);

                    int mechRows = cmdMech.ExecuteNonQuery();
                    return mechRows > 0;
                }
            } catch (Exception ex) {
                Console.WriteLine("AddNewMechanic Error: " + ex.Message);
                return false;
            }
        }

        public bool UpdateMechanic(int userId, string name, string gender, string password, DateTime dob, string bloodGroup, string email, float rating, string status) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    conn.Open();

                    // Update Users
                    string updateUserQuery = @"UPDATE Users
                                       SET Name = @Name, Gender = @Gender, Password = @Password,
                                           DateOfBirth = @DateOfBirth, BloodGroup = @BloodGroup,
                                           Email = @Email
                                       WHERE UserID = @UserID AND LOWER(UserType) = 'mechanic'";

                    SqlCommand cmdUser = new SqlCommand(updateUserQuery, conn);
                    cmdUser.Parameters.AddWithValue("@UserID", userId);
                    cmdUser.Parameters.AddWithValue("@Name", name);
                    cmdUser.Parameters.AddWithValue("@Gender", gender ?? (object)DBNull.Value);
                    cmdUser.Parameters.AddWithValue("@Password", password);
                    cmdUser.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmdUser.Parameters.AddWithValue("@BloodGroup", bloodGroup ?? (object)DBNull.Value);
                    cmdUser.Parameters.AddWithValue("@Email", email);

                    int userRows = cmdUser.ExecuteNonQuery();
                    if (userRows <= 0) return false;

                    // Update Mechanics
                    string updateMechanicQuery = @"UPDATE Mechanics
                                           SET Rating = @Rating, Status = @Status
                                           WHERE UserID = @UserID";

                    SqlCommand cmdMech = new SqlCommand(updateMechanicQuery, conn);
                    cmdMech.Parameters.AddWithValue("@UserID", userId);
                    cmdMech.Parameters.AddWithValue("@Rating", rating);
                    cmdMech.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);

                    int mechRows = cmdMech.ExecuteNonQuery();
                    return mechRows > 0;
                }
            } catch (Exception ex) {
                Console.WriteLine("UpdateMechanic Error: " + ex.Message);
                return false;
            }
        }

    }
}
