﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Common.Enums;

namespace DAL.Models
{
    public class TShirt : Clothes
    {
       

        public override void UpdateSellingPrice(ClothesType type, decimal newPrice)
        {
            if (type == ClothesType.TShirt)
            {
                SellPrice = newPrice;
            }
        }
    }
}
