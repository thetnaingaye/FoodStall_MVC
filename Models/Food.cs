namespace FoodStall_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        public int FoodID { get; set; }

        [StringLength(255)]
        public string FoodName { get; set; }
    }
}
