using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Orders
{
    public class OrderItem
    {
        public string OrderItemId { get; set; }
        public Clothes Clothes { get; set; }
        public int Amount { get; set; }
    }
}
