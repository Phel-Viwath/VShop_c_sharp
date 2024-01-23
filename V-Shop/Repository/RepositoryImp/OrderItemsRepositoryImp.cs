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
    public class OrderDetail : IOrderItemsRepository
    {
        DatabaseHelper dbHelper = new DatabaseHelper();

        public void SaveOrderDetail(OrderItem orderItem)
        {
            string query = "Insert into OrderItems(OrderID, ProductID, Qauntity, Subtotal, Cashier_id, Total_price)" +
                "Values(@orderId, @productId, @qty, @subtotal, @cashierId, @totalPrice)";
            try
            {
                using(SqlConnection conn = dbHelper.OpenConnection())
                {
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderItem.OrderId);
                        cmd.Parameters.AddWithValue("@productId", orderItem.ProductId);
                        cmd.Parameters.AddWithValue("@qty", orderItem.Qty);
                        cmd.Parameters.AddWithValue("@subtotal", orderItem);
                        cmd.Parameters.AddWithValue("cashierId", orderItem.CashierId);
                        cmd.Parameters.AddWithValue("@totalPrice", orderItem.TotalPrice);
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error insert orderItems" + ex.Message);
            }
        }
    }
}
