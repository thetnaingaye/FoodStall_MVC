﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodStall_MVC.Startup))]
namespace FoodStall_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
