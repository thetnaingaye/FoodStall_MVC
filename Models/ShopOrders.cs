namespace FoodStall_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopOrders : DbContext
    {
        public ShopOrders()
            : base("name=ShopOrders")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.UserName)
                .IsFixedLength();
        }
    }
}
