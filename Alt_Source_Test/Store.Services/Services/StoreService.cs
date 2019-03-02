using DAL;
using DAL.Models;
using DAL.Models.Orders;
using Store.Common.Enums;
using Store.Services.Interfaces;
using Store.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Services
{
    public class StoreService : IStoreService
    {

        public void MakeOrder(List<OrderItemData> orderItemDatas)
        {
            var order = new Order();
            var orderItems = new List<OrderItem>();
            foreach (var item in orderItemDatas)
            {
                var clothes = AddClothes(item.Type, item.Price, item.Size, item.Color, item.Amount);
                orderItems.Add(new OrderItem
                {
                    Amount = item.Amount,
                    OrderItemId = Guid.NewGuid().ToString(),
                    Clothes = clothes
                });

            }

            order.OrderItems = orderItems;
            order.SupplierId = orderItemDatas.FirstOrDefault().SupplierId;

            DbContext.AddOrder(order);
        }

        public IEnumerable<ClothesDetails> GetClothesSellingPrice()
        {
            var tShirtType = DbContext.GetClothes().Where(x => x.GetType() == typeof(TShirt)).FirstOrDefault();

            if (tShirtType != null)
            {
                yield return new ClothesDetails
                {
                    SellPrice = tShirtType.SellPrice,
                    Type = ClothesType.TShirt
                };
            }

            var dressShirtType = DbContext.GetClothes().Where(x => x.GetType() == typeof(DressShirt)).FirstOrDefault();

            if (dressShirtType != null)
            {
                yield return new ClothesDetails
                {
                    SellPrice = dressShirtType.SellPrice,
                    Type = ClothesType.DressShirt
                };
            }
        }


        private Clothes AddClothes(ClothesType type, decimal buyPrice, Sizes size, Colors color, int amount)
        {
            Clothes clothes = null;
            switch (type)
            {
                case ClothesType.DressShirt:
                    clothes = new DressShirt()
                    {
                        SellPrice = 8,
                    };
                    break;

                case ClothesType.TShirt:
                    clothes = new TShirt()
                    {
                        SellPrice = 12
                    };
                    break;
            }

            if (clothes == null)
            {
                throw new Exception("Cannot determine the clothes type");
            }

            clothes.Amount = amount;
            clothes.Id = Guid.NewGuid().ToString();
            clothes.BuyPrice = buyPrice;
            clothes.Color = color;
            clothes.Size = size;


            DbContext.AddClothes(clothes);

            return clothes;
        }

        public void UpdateSellingPrice(ClothesType type, decimal newPrice)
        {
            DbContext.GetClothes().ForEach(x =>
            {
                x.UpdateSellingPrice(type, newPrice);  

            });
        }
    }

}
