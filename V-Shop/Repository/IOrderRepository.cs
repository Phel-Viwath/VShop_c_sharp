using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Shop.Data.Model.Order;

namespace V_Shop.Repository
{
    public interface IOrderRepository
    {
        void SaveOrder(Order order);
        List<Order> GetOrders();
        Order GetOrderById(int id);
    }
}
