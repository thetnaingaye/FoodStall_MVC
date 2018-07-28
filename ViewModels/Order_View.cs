using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodStall_MVC.ViewModels
{
    public class Order_View
    {
        public int OrderId { get; set; }

  
        public string UserName { get; set; }

        public int FoodID { get; set; }

        public int Size { get; set; }


        public bool Chilli { get; set; }


        public bool MoreSalt { get; set; }


        public bool Pepper { get; set; }
    }
}