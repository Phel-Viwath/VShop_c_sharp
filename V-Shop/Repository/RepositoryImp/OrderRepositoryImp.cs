using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Data.Model.Order;

namespace V_Shop.Repository.RepositoryImp
{
    public class OrderRepositoryImp : IOrderRepository
    {
        private readonly DatabaseHelper dbHelper;

        public OrderRepositoryImp(DatabaseHelper dbHelper)
        { 
            this.dbHelper = dbHelper;
        }

        public Order GetOrderById(int id)
        {
            Order order = new Order();
            string query = $"Insert * From Orders Where OrderID = '{id}'";
            try
            {
                using(SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        var _order = new Order
                        {
                            OrderID = Convert.ToInt32(reader[0]),
                            CutomerID = Convert.ToInt32(reader[1]),
                            OrderDate = Convert.ToDateTime(reader[2]),
                            TotalAmount = Convert.ToDouble(reader[3])
                        };
                        order = _order;
                    }
                    
                }
                return order;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "Select * from Orders";
            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        var _order = new Order
                        {
                            OrderID = Convert.ToInt32(reader[0]),
                            CutomerID = Convert.ToInt32(reader[1]),
                            OrderDate = Convert.ToDateTime(reader[2]),
                            TotalAmount = Convert.ToDouble(reader[3])
                        };
                        orders.Add(_order);
                    }
                }
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void SaveOrder(Order order)
        {
            string query = "Insert into Orders( CustomerID, OrderDate, TotalAmount" +
                "Values(@customerId, @orderDate, @totalAmount)";
            try
            {
                using (SqlConnection conn = dbHelper.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", order.CutomerID);
                        cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                        cmd.Parameters.AddWithValue("@totalAmount", order.TotalAmount);
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
