using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class Meal
    {
        public Meal()
        {
            LinkMealRecipe = new HashSet<LinkMealRecipe>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public long? MealTypeId { get; set; }
        public long? MealCategoryId { get; set; }

        [ForeignKey(nameof(MealCategoryId))]
        [InverseProperty(nameof(MealCategoryLu.Meal))]
        public virtual MealCategoryLu MealCategory { get; set; }
        [ForeignKey(nameof(MealTypeId))]
        [InverseProperty(nameof(MealTypeLu.Meal))]
        public virtual MealTypeLu MealType { get; set; }
        [InverseProperty("Meal")]
        public virtual ICollection<LinkMealRecipe> LinkMealRecipe { get; set; }
    }
}
