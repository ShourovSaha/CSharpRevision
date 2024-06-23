using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    public class Customer
    {
        private Lazy<List<Order>> _orders = null;
        public List<Order> Orders
        {
            get
            {
                return _orders.Value;
            }
        }

        private string _customerName;
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }
        }

        public Customer()
        {
            _customerName = "S Saha";
            _orders = new Lazy<List<Order>>(loadOrders());
        }

        private List<Order> loadOrders()
        {
            List<Order> orders = new List<Order>();
            Order order = new Order
            {
                OrderId = "odr10001",
            };
            orders.Add(order);

            order = new Order
            {
                OrderId = "odr10002",
            };
            orders.Add(order);
            return orders;
        }
    }
}
