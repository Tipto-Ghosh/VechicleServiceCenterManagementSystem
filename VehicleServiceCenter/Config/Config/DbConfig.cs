using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace VehicleServiceCenter.Config {

    // This is a class where we do the database connection part
    public static class DbConfig {
        // Update the connection string 
        public static string connectionString =
           @"Data Source=TECH\SQLEXPRESS;Integrated Security=True;Trust Server Certificate=True";

        // This a method which will create a SqlConnection and return a SqlConnection Object
        public static SqlConnection GetConnection() {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
