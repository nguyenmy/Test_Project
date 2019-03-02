using DAL.Models;
using Store.Common.Enums;
using Store.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Interfaces
{
    public interface IStoreService
    {
         void MakeOrder(List<OrderItemData> orderItems);
         IEnumerable<ClothesDetails> GetClothesSellingPrice();
        void UpdateSellingPrice(ClothesType type, decimal newPrice);
    }
}
