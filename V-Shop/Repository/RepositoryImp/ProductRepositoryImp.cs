using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Repository;

namespace V_Shop.Data.Product
{
    public class ProductRepositoryImp: IProductRepository
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private int qty;

        // Save product
        public void Save(Product product)
        {
            try
            {
                
                string query = "INSERT INTO Product (Name, Sale_price, Corrent_qty, Description, ImageData, Category) " +
                       "VALUES(@Name, @PriceOut, @Current_qty, @Description, @ImageData, @Category)";

                using (SqlConnection connection = dbHelper.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@PriceOut", product.SalePrice);
                        cmd.Parameters.AddWithValue("@Current_qty", product.Qty);
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
                            SalePrice = Convert.ToDouble(reader["Sale_price"]),
                            Qty = Convert.ToInt32(reader["Corrent_qty"]),
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
                MessageBox.Show("Error in get all product" + ex.Message);
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
                            SalePrice = Convert.ToDouble(reader["Sale_price"]),
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
                            SalePrice = Convert.ToDouble(reader["Sale_price"]),
                            Qty = Convert.ToInt32(reader["Corrent_qty"]),
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
            string query = $"Update Product Set Name = @Name, Sale_price = @PriceOut, Current_qty = @Qty," +
                $"Description = @Description, Category = @Category, ImageData = @ImageData Where Id = '{id}'";
            try
            {
                using(SqlConnection conn = dbHelper.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@PriceOut", product.SalePrice);
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

        /// Select the last id from table product
        public int GetLastProductID()
        {
            string query = "SELECT IDENT_CURRENT('Product') AS last_id";
            int lastId = 0;
            try
            {
                using(SqlDataReader r = dbHelper.ExecuteReader(query))
                {
                    if (r.Read())
                    {
                        lastId = Convert.ToInt32(r[0]);
                    }
                }
                return lastId;
            }catch (Exception ex)
            {
                MessageBox.Show ("Error when get last ID From table product" + ex.Message);
                return -1;
            }
        }
    }
}
