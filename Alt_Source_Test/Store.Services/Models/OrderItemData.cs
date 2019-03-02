using DAL.Models;
using Store.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Models
{
    public class OrderItemData
    {
        public int OrderItemId { get; set; }
        public ClothesType Type { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Sizes Size { get; set; }
        public Colors Color { get; set; }
        public int SupplierId { get; set; }
    }
}
