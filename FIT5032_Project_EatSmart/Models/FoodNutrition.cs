namespace FIT5032_Project_EatSmart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodNutrition")]
    public partial class FoodNutrition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string FoodName { get; set; }

        public double? Energy { get; set; }

        public double? Protein { get; set; }

        public double? TotalFat { get; set; }

        public double? Carbohydrates { get; set; }

        public double? TotalSugars { get; set; }

        public double? Calcium { get; set; }

        public double? Sodium { get; set; }

        public double? SaturatedFat { get; set; }
    }
}
