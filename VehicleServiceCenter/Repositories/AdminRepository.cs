using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VehicleServiceCenter.Repositories
{
    public class AdminRepository
    {


        /* 
        From the Form we will take all the info(UserInfo + AdminInfo).
        Add the user. 
        if userAdded successfull then it will return the newUserId.
        Take the userId and and adminExtra info and pass to the InsertAdmin

        */
        public int InsertAdmin(Admin admin)
        {
            try
            {
                UserRepository userRepository = new UserRepository();

                // 1. Insert into Users table
                int newId = userRepository.InsertUser(admin);
                if (newId == -1 || newId == 0)
                {
                    return 0; // Duplicate or failed
                }

                // 2. Insert into Admins table
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO Admins (UserID, Type, CreatedDate) VALUES (@UserID, @Type, @CreatedDate)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", newId);
                    cmd.Parameters.AddWithValue("@Type", admin.Type);
                    cmd.Parameters.AddWithValue("@CreatedDate", admin.CreatedDate);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0 ? newId : 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("InsertAdmin Error: " + ex.Message);
                return 0;
            }
        }

        /*
        To update a admin also first take the id.
        Update the User. If Done then update Admin Extra info if Failed go back to previous state
        */

        public int UpdateAdmin(Admin admin)
        {
            try
            {
                UserRepository userRepository = new UserRepository();

                // 1. Update User Info
                int status = userRepository.UpdateUser(admin);
                if (status == -1 || status == 0)
                {
                    return status;
                }

                // 2. Update Admin table
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE Admins SET Type = @Type, CreatedDate = @CreatedDate WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Type", admin.Type);
                    cmd.Parameters.AddWithValue("@CreatedDate", admin.CreatedDate);
                    cmd.Parameters.AddWithValue("@UserID", admin.UserID);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0 ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateAdmin Error: " + ex.Message);
                return 0;
            }
        }

        public int DeleteAdmin(int adminId)
        {
            try
            {
                UserRepository userRepository = new UserRepository();
                return userRepository.DeleteUser(adminId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeleteAdmin Error: " + ex.Message);
                return 0;
            }
        }

        public List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"SELECT U.*, A.Type, A.CreatedDate 
                                     FROM Users U 
                                     INNER JOIN Admins A ON U.UserID = A.UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Admin admin = new Admin();
                        admin.UserID = Convert.ToInt32(reader["UserID"]);
                        admin.Name = reader["Name"].ToString();
                        admin.Gender = reader["Gender"].ToString();
                        admin.Password = reader["Password"].ToString();
                        admin.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        admin.BloodGroup = reader["BloodGroup"].ToString();
                        admin.Email = reader["Email"].ToString();
                        admin.UserType = reader["UserType"].ToString();
                        admin.Type = reader["Type"].ToString();
                        admin.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);


                        admins.Add(admin);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetAllAdmins Error: " + ex.Message);
            }

            return admins;
        }


        public DataTable GetAllAdminsDataTable() {
            DataTable adminTable = new DataTable();

            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"SELECT U.*, A.Type, A.CreatedDate FROM Users U INNER JOIN Admins A ON U.UserID = A.UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                            adapter.Fill(adminTable);
                        }
                    }
                }
            }catch(Exception ex) {
                Console.WriteLine("Admin DataTable Get Error(GetAllAdminsDataTable()) " + ex.Message);
            }

            return adminTable;
        }
        
    }
}
