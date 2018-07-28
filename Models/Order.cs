namespace FoodStall_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }

        public int FoodID { get; set; }

        public int Size { get; set; }

        [Required]
        [StringLength(1)]
        public string Chilli { get; set; }

        [Required]
        [StringLength(1)]
        public string MoreSalt { get; set; }

        [Required]
        [StringLength(1)]
        public string Pepper { get; set; }
    }
}
