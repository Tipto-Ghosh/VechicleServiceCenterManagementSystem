using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories {
    public class AdminRepository {


        /* 
        From the Form we will take all the info(UserInfo + AdminInfo).
        Add the user. 
        if userAdded successfull then it will return the newUserId.
        Take the userId and and adminExtra info and pass to the InsertAdmin

        */
        public int InsertAdmin(Admin admin) {
            try {
                UserRepository userRepository = new UserRepository();

                // 1. Insert into Users table
                int newId = userRepository.InsertUser(admin);
                if (newId == -1 || newId == 0) {
                    return 0; // Duplicate or failed
                }

                // 2. Insert into Admins table
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"INSERT INTO Admins (UserID, Type, CreatedDate) 
                                     VALUES (@UserID, @Type, @CreatedDate)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", newId);
                    cmd.Parameters.AddWithValue("@Type", admin.Type);
                    cmd.Parameters.AddWithValue("@CreatedDate", admin.CreatedDate);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0 ? newId : 0;
                }
            } catch (Exception ex) {
                Console.WriteLine("InsertAdmin Error: " + ex.Message);
                return 0;
            }
        }

        /*
        To update a admin also first take the id.
        Update the User. If Done then update Admin Extra info if Failed go back to previous state
        */

        public int UpdateAdmin(Admin admin) {
            try {
                UserRepository userRepository = new UserRepository();

                // 1. Update User Info
                int status = userRepository.UpdateUser(admin);
                if (status == -1 || status == 0) {
                    return status;
                }

                // 2. Update Admin table
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"UPDATE Admins SET Type = @Type, CreatedDate = @CreatedDate 
                                     WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Type", admin.Type);
                    cmd.Parameters.AddWithValue("@CreatedDate", admin.CreatedDate);
                    cmd.Parameters.AddWithValue("@UserID", admin.UserID);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0 ? 1 : 0;
                }
            } catch (Exception ex) {
                Console.WriteLine("UpdateAdmin Error: " + ex.Message);
                return 0;
            }
        }

        public int DeleteAdmin(int adminId) {
            try {
                UserRepository userRepository = new UserRepository();
                return userRepository.DeleteUser(adminId);
            } catch (Exception ex) {
                Console.WriteLine("DeleteAdmin Error: " + ex.Message);
                return 0;
            }
        }

        public List<Admin> GetAllAdmins() {
            List<Admin> admins = new List<Admin>();
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"SELECT U.*, A.Type, A.CreatedDate 
                                     FROM Users U 
                                     INNER JOIN Admins A ON U.UserID = A.UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        Admin admin = new Admin {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Password = reader["Password"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            BloodGroup = reader["BloodGroup"].ToString(),
                            Email = reader["Email"].ToString(),
                            UserType = reader["UserType"].ToString(),
                            Type = reader["Type"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                        };

                        admins.Add(admin);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("GetAllAdmins Error: " + ex.Message);
            }

            return admins;
        }
    }
}
