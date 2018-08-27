using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodStall_MVC.Models
{
    public class BizLogic
    {
        public static List<Food> GetFoodList()
        {
            using (ShopOrders so = new ShopOrders())
            {
                return so.Foods.ToList();
            }
        }

        public static int GetFoodID(string foodname)
        {
            using (ShopOrders so = new ShopOrders())
            {
                return so.Foods.Where(f => f.FoodName == foodname).Select(s => s.FoodID).First();
            }
        }

        internal static List<Order> GetOrders()
        {
            using (ShopOrders so = new ShopOrders())
            {
                return so.Orders.ToList();
            }
        }

        public static string GetFoodName(int foodID)
        {
            using (ShopOrders so = new ShopOrders())
            {
                return so.Foods.Where(f => f.FoodID == foodID).Select(s => s.FoodName).First();
            }
        }
        public static bool MakeOrder(string custname, int foodid, int size, string chilli, string moresalt, string pepper)
        {

            using (ShopOrders so = new ShopOrders())
            {

                Order o = new Order();
                o.UserName = custname;
                o.FoodID = foodid;
                o.Size = size;
                o.Chilli = chilli;
                o.MoreSalt = moresalt;
                o.Pepper = pepper;
                try
                {
                    so.Orders.Add(o);
                    so.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }


            }
        }
        public static List<Order> GetOrderbyUserName(string userName)
        {
            using (ShopOrders so = new ShopOrders())
            {
                return so.Orders.Where(o => o.UserName == userName).ToList();
            }

        }
        public static Order GetOrderbyOrderID(int orderid)
        {
            using (ShopOrders so = new ShopOrders())
            {
                return so.Orders.Where(o => o.OrderId == orderid).ToList().FirstOrDefault();
            }

        }
        public static void UpdateOrder(int orderid,string custname, int foodid, int size, string chilli, string moresalt, string pepper)
        {
            using (ShopOrders so = new ShopOrders())
            {
                Order orderUpdate = so.Orders.Where(o => o.OrderId == orderid).ToList().FirstOrDefault();
               // orderUpdate.UserName = custname;
                orderUpdate.FoodID = foodid;
                orderUpdate.Size = size;
                orderUpdate.Chilli = chilli;
                orderUpdate.MoreSalt = moresalt;
                orderUpdate.Pepper = pepper;
                //so.Orders.AddOrUpdate(od);
                so.SaveChanges();
            }

        }
        public static bool DeleteOrder(int orderid)
        {
            using (ShopOrders so = new ShopOrders())
            {

                Order order = so.Orders.Where(o => o.OrderId == orderid).First();
                try
                {
                    so.Orders.Remove(order);
                    so.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }


            }
        }
    }
}