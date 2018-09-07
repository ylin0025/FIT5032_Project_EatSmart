namespace FIT5032_Project_EatSmart.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodNutritionModdels : DbContext
    {
        public FoodNutritionModdels()
            : base("name=FoodNutritionModdels")
        {
        }

        public virtual DbSet<FoodNutrition> FoodNutritions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodNutrition>()
                .Property(e => e.FoodName)
                .IsUnicode(false);
        }
    }
}
