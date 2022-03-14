using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class OrderRepository
    {
        public List<Order> Orders;

        public OrderRepository()
        {
            Orders = new List<Order>();
        }

        public void Add(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> getAll()
        {
            return Orders;
        }
    }
}
