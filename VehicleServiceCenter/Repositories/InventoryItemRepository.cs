using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories {
    public class InventoryItemRepository {

        public int InsertItem(InventoryItem item) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"INSERT INTO InventoryItems (ItemName, RemainingNumber, Price)
                                     VALUES (@ItemName, @RemainingNumber, @Price)";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                        cmd.Parameters.AddWithValue("@RemainingNumber", item.RemainingNumber);
                        cmd.Parameters.AddWithValue("@Price", item.Price);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? 1 : 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }



        public int UpdateItem(InventoryItem item) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"UPDATE InventoryItems SET 
                                        ItemName = @ItemName,
                                        RemainingNumber = @RemainingNumber,
                                        Price = @Price
                                     WHERE InventoryItemID = @InventoryItemID";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                        cmd.Parameters.AddWithValue("@RemainingNumber", item.RemainingNumber);
                        cmd.Parameters.AddWithValue("@Price", item.Price);
                        cmd.Parameters.AddWithValue("@InventoryItemID", item.InventoryItemID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? 1 : 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int DeleteItem(int itemId) {
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "DELETE FROM InventoryItems WHERE InventoryItemID = @InventoryItemID";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@InventoryItemID", itemId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? 1 : 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public List<InventoryItem> GetLowStockItems(int count) {
            List<InventoryItem> items = new List<InventoryItem>();
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = @"SELECT TOP (@Count) InventoryItemID, ItemName, RemainingNumber, Price
                                     FROM InventoryItems
                                     ORDER BY RemainingNumber ASC";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@Count", count);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                items.Add(new InventoryItem {
                                    InventoryItemID = Convert.ToInt32(reader["InventoryItemID"]),
                                    ItemName = reader["ItemName"].ToString(),
                                    RemainingNumber = Convert.ToInt32(reader["RemainingNumber"]),
                                    Price = Convert.ToDecimal(reader["Price"])
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return items;
        }

        public List<InventoryItem> GetAllItems() {
            List<InventoryItem> items = new List<InventoryItem>();
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT InventoryItemID, ItemName, RemainingNumber, Price FROM InventoryItems";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                items.Add(new InventoryItem {
                                    InventoryItemID = Convert.ToInt32(reader["InventoryItemID"]),
                                    ItemName = reader["ItemName"].ToString(),
                                    RemainingNumber = Convert.ToInt32(reader["RemainingNumber"]),
                                    Price = Convert.ToDecimal(reader["Price"])
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return items;
        }

        public InventoryItem GetInventoryItemById(int id) {
            InventoryItem item = null;
            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT InventoryItemID, ItemName, RemainingNumber, Price FROM InventoryItems WHERE InventoryItemID = @InventoryItemID";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@InventoryItemID", id);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                item = new InventoryItem {
                                    InventoryItemID = Convert.ToInt32(reader["InventoryItemID"]),
                                    ItemName = reader["ItemName"].ToString(),
                                    RemainingNumber = Convert.ToInt32(reader["RemainingNumber"]),
                                    Price = Convert.ToDecimal(reader["Price"])
                                };
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return item;
            }
            return item;
        }

    }
}
