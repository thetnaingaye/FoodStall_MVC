using FoodStall_MVC.Models;
using FoodStall_MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodStall_MVC.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }

        [Route("orders/new")]
        public ActionResult New()
        {

            var foodLists = BizLogic.GetFoodList();
            var orderViewModel = new ViewModels.OrderFormViewModel
            {
                Order = new Order_View(),
                FoodLists = foodLists

            };

            return View("New", orderViewModel);
        }
        [HttpPost]
        [Route("orders/save")]
        public ActionResult Save(OrderFormViewModel orderformViewModel)
        {
            string custName = orderformViewModel.Order.UserName;
            int foodId = orderformViewModel.Order.FoodID;
            int size = orderformViewModel.Order.Size;
            string chilli = orderformViewModel.Order.Chilli ? "Y" : "N";
            string moresalt = orderformViewModel.Order.MoreSalt ? "Y" : "N";
            string pepper = orderformViewModel.Order.Pepper ? "Y" : "N";

            BizLogic.MakeOrder(custName, foodId, size, chilli, moresalt, pepper);
            return Redirect("~/orders/" + custName);
        }


        [Route("orders/{custName}")]
        public ActionResult OrdersByCust(string custName)
        {

            List<Order> orders = BizLogic.GetOrderbyUserName(custName);
            ViewBag.orders = orders;
            return View();
        }

        [Route("orders/delete/{orderid}")]
        public ActionResult DeleteOrder(int orderid)
        {
            Order o = BizLogic.GetOrderbyOrderID(orderid);
            BizLogic.DeleteOrder(orderid);
            return Redirect("~/orders/" + o.UserName);
        }

        [Route("orders/summary")]
        public ActionResult Summary()
        {
           return View();
        }
    }
}