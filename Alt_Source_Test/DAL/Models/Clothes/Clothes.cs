using Store.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    
    public abstract class Clothes
    {
        public string Id { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public Sizes Size { get; set; }
        public Colors Color { get; set; }
        public int Amount { get; set; }
        public abstract void UpdateSellingPrice(ClothesType type,decimal newPrice);
    }
}
