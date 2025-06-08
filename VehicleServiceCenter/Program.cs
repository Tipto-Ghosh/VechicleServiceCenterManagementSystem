using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter {
    internal static class Program {
        static void Main(string[] args) {

            //string connString = DbConfig.connectionString;


            //try {
            //    using (SqlConnection conn = new SqlConnection(connString)) {
            //        conn.Open();

            //        string insertQuery = @"
            //            INSERT INTO Users 
            //            (Name, Gender, Password, DateOfBirth, BloodGroup, Email, UserType) 
            //            VALUES (@Name, @Gender, @Password, @DateOfBirth, @BloodGroup, @Email, @UserType);
            //        ";

            //        using (SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
            //            // Set parameter values
            //            cmd.Parameters.AddWithValue("@Name", "Tipto");
            //            cmd.Parameters.AddWithValue("@Gender", "Male");
            //            cmd.Parameters.AddWithValue("@Password", "1234"); 
            //            cmd.Parameters.AddWithValue("@DateOfBirth", new DateTime(2004, 12, 5));
            //            cmd.Parameters.AddWithValue("@BloodGroup", "B-");
            //            cmd.Parameters.AddWithValue("@Email", "tipto@gmail.com");
            //            cmd.Parameters.AddWithValue("@UserType", "Customer");

            //            int rowsAffected = cmd.ExecuteNonQuery();

            //            Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
            //        }
            //    }
            //} catch (Exception ex) {
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            UserRepository userRepository = new UserRepository();

            //User user = userRepository.GetUserById(1000);
            //User user = userRepository.GetUserByEmail("bob.manager@example.com");

            //if (user == null) {
            //    Console.WriteLine("Failed");
            //}else {
            //    Console.WriteLine(user.Name);
            //}


            //int check = userRepository.DeleteUser(1014); 

            

            AdminRepository adminRepository = new AdminRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
