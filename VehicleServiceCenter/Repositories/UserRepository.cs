using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Config;
using System.Data.SqlClient;

namespace VehicleServiceCenter.Repositories {
    public class UserRepository {
        private string connString = DbConfig.connectionString;
        public User GetUserById(int id) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT * FROM Users WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Fill the placholders
                    cmd.Parameters.AddWithValue("@UserID", id);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true) {
                        User user = new User {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Password = reader["Password"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            BloodGroup = reader["BloodGroup"].ToString(),
                            Email = reader["Email"].ToString(),
                            UserType = reader["UserType"].ToString()
                        };

                        return user;
                    } else {
                        return null; // not found
                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public User GetUserByEmail(string email) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT * FROM Users WHERE Email = @Email";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Fill the placholders
                    cmd.Parameters.AddWithValue("@Email", email);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true) {
                        User user = new User {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Password = reader["Password"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            BloodGroup = reader["BloodGroup"].ToString(),
                            Email = reader["Email"].ToString(),
                            UserType = reader["UserType"].ToString()
                        };

                        return user;
                    } else {
                        return null; // not found
                    }
                }

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        // This will insert a new User 
        public int InsertUser(User user) {
            try {
                // before inserting check user already exists or not
                var existUser = GetUserByEmail(user.Email);
                if (existUser != null) {
                    // Email is found, means already this user exists. return -1
                    return -1;
                }

                // User not exists so insert 
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"INSERT INTO Users (Name, Gender, Password, DateOfBirth, BloodGroup, Email, UserType)
                                   VALUES (@Name, @Gender, @Password, @DateOfBirth, @BloodGroup, @Email, @UserType);
                                   SELECT SCOPE_IDENTITY();";


                    SqlCommand cmd = new SqlCommand(query, conn);

                    // set all values
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Gender", user.Gender ?? (object)DBNull.Value); // safety -> if value is missing from form then pass null
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    cmd.Parameters.AddWithValue("@BloodGroup", user.BloodGroup ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@UserType", user.UserType);

                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    int newUserId;
                    if (result != null && int.TryParse(result.ToString(), out newUserId)) {
                        return newUserId; // Success
                    }

                    return 0; // Fail to insert. Some Issue
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


        // This a method to update a Existing user's info
        public int UpdateUser(User user) {
            /* 
            If user not existis return -1
            If Update done return 1
            If update failed return 0
            */
            try {
                // Find the User
                Object exists = GetUserById(user.UserID);
                if (exists == null) {
                    return -1;
                }

                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"UPDATE Users SET Name = @Name,Gender = @Gender,Password = @Password,
                                     DateOfBirth = @DateOfBirth,BloodGroup = @BloodGroup,Email = @Email,
                                     UserType = @UserType WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Gender", user.Gender ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    cmd.Parameters.AddWithValue("@BloodGroup", user.BloodGroup ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@UserType", user.UserType);
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0 ? 1 : 0;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


        // Method to delete a User
        public int DeleteUser(int userId) {
            /* 
            If user not existis return -1
            If  done return 1
            If update failed return 0
            */
            try {
                object exists = GetUserById(userId);
                if (exists == null) {
                    return -1;
                }
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "DELETE FROM Users WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0 ? 1 : 0;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool ChangePassword(int userId, string newPassword) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


    }
}
