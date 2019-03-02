using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Orders
{
    public class Order
    {
        public string OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int SupplierId { get; set; }
    }
}
