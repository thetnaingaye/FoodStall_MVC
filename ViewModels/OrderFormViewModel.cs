using FoodStall_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodStall_MVC.ViewModels
{
    public class OrderFormViewModel
    {
        public IEnumerable<Food> FoodLists{ get; set; }
        public Order_View Order { get; set; }

    }
}