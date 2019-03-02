using DAL.Models;
using DAL.Models.Orders;
using DAL.Models.Suppliers;
using Store.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public static class DbContext
    {
        private static List<Clothes> Clothes = new List<Clothes>();

        private static List<Order> Orders = new List<Order>();

        private static List<Supplier> Suppliers = new List<Supplier>();

        public static void AddClothes(Clothes clothes)
        {
            Clothes.Add(clothes);
        }

        public static void RemoveClothes(List<string> clothesIds)
        {
            var removedClothes = Clothes.Where(x => clothesIds.Contains(x.Id));
        }

        public static void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public static void AddSupplier(Supplier supplier)
        {
            Suppliers.Add(supplier);
        }

        public static Clothes GetClothes(string id)
        {
            return Clothes.FirstOrDefault(x => x.Id == id);
        }

        public static List<Clothes> GetClothes()
        {
            return Clothes;
        }

        
    }
}
