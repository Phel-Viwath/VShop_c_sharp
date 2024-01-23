using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Shop.Data.Product
{
    public class ProductRepository
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private int qty;

        // Save product
        public void Save(Product product)
        {
            try
            {
                
                string query = "INSERT INTO Product (Name, Price_In, Price_Out, Current_qty, Description, ImageData, Category) " +
                       "VALUES(@Name, @PriceIn, @PriceOut, @Qty, @Description, @ImageData, @Category)";

                using (SqlConnection connection = dbHelper.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@PriceIn", product.PriceIn);
                        cmd.Parameters.AddWithValue("@PriceOut", product.PriceOut);
                        cmd.Parameters.AddWithValue("@Qty", product.Qty);
                        cmd.Parameters.AddWithValue("@Description", product.Description);
                        cmd.Parameters.AddWithValue("@ImageData", product.ImageData);
                        cmd.Parameters.AddWithValue("@Category", product.Category);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving product to the database: " + ex.Message);
            }
        }

        // Select all product
        public List<Product> GetAllProducts()
        {
            List<Product> productsList = new List<Product>();

            try
            {
                string query = "SELECT * FROM Product";
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = Convert.ToString(reader["Name"]),
                            PriceIn = Convert.ToDouble(reader["Price_In"]),
                            PriceOut = Convert.ToDouble(reader["Price_Out"]),
                            Qty = Convert.ToInt32(reader["Current_qty"]),
                            Description = Convert.ToString(reader["Description"]),
                            ImageData = (byte[])reader["ImageData"],
                            Category = Convert.ToString(reader["Category"]),
                        };
                        productsList.Add(product);
                    }
                }
                return productsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //// Get all product if qty > 0
        public List<Product> GetAllProductInStock()
        {
            List<Product> productList = new List<Product>();

            try
            {

                string query = "SELECT * FROM Product WHERE Corrent_qty > 0";
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = Convert.ToString(reader["Name"]),
                            PriceIn = Convert.ToDouble(reader["Price_In"]),
                            PriceOut = Convert.ToDouble(reader["Price_Out"]),
                            Qty = Convert.ToInt32(reader["Corrent_qty"]),
                            Description = Convert.ToString(reader["Description"]),
                            ImageData = (byte[])reader["ImageData"],
                            Category = Convert.ToString(reader["Category"]),
                        };
                        productList.Add(product);
                    }
                }
                return productList;

            }catch (Exception ex)
            {
                MessageBox.Show("Error in get all product in stock" + ex.Message);
                return null;
            }
        }

        // Delete Product 
        public void DeleteProduct(int id)
        {
            string query = $"DELETE FROM Product WHERE Id = '{id}'";
            try
            {
                dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// Select Product By ID
        public Product GetProduct(int id)
        {
            string qurey = $"SELECT * FROM Product WHERE Id = '{id}'";
            Product product;
            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(qurey))
                {

                    if (reader.Read())
                    {
                        product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = Convert.ToString(reader["Name"]),
                            Description = Convert.ToString(reader["Description"]),
                            Category = Convert.ToString(reader["Category"]),
                            PriceIn = Convert.ToDouble(reader["Price_In"]),
                            PriceOut = Convert.ToDouble(reader["Price_Out"]),
                            Qty = Convert.ToInt32(reader["Current_qty"]),
                            ImageData = (byte[])reader["ImageData"]  ,

                        };
                        return product;
                    }
                    else return null;
                }
                
            }catch (Exception e) { MessageBox.Show(e.Message); return null; }
        }
        
        // Update Product
        public void UpdateProduct(Product product, int id)
        {
            string query = $"Update Product Set Name = @Name, Price_In = @PriceIn, Price_Out = @PriceOut, Current_qty = @Qty," +
                $"Description = @Description, Category = @Category, ImageData = @ImageData Where Id = '{id}'";
            try
            {
                using(SqlConnection conn = dbHelper.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@PriceIn", product.PriceIn);
                        cmd.Parameters.AddWithValue("@PriceOut", product.PriceOut);
                        cmd.Parameters.AddWithValue("@Qty", product.Qty);
                        cmd.Parameters.AddWithValue("@Description", product.Description);
                        cmd.Parameters.AddWithValue("@ImageData", product.ImageData);
                        cmd.Parameters.AddWithValue("@Category", product.Category);
                        cmd.ExecuteNonQuery();
                    }
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show("Error update" + ex.Message); 
            }
        }
       
        public void BuyProduct(int product_id, int buyQty)
        {
            string updateQuery = $"Update Product Set Current_qty = @Qty Where Id = '{product_id}'";
            string selectQtyQuery = $"SELECT Current_qty FROM Product WHERE Id = {product_id}";

            try
            {
                using(SqlDataReader reader = dbHelper.ExecuteReader(selectQtyQuery))
                {
                    if (reader.Read())
                    {
                        qty = Convert.ToInt32(reader["Current_qty"]);
                    }
                }

                //// Minus stock
                using( SqlConnection conn = dbHelper.OpenConnection())
                {
                    using(SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Qty", qty - buyQty);
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error buy {ex.Message}");
            }
        }



    }
}
