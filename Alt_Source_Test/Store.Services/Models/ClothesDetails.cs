using Store.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Models
{
    public class ClothesDetails
    {
        public ClothesType Type { get; set; }
        public decimal SellPrice { get; set; }
    }
}
