using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class LinkMealRecipe
    {
        [Key]
        public long Id { get; set; }
        public long? MealId { get; set; }
        public Guid? RecipeId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey(nameof(MealId))]
        [InverseProperty("LinkMealRecipe")]
        public virtual Meal Meal { get; set; }
        [ForeignKey(nameof(RecipeId))]
        [InverseProperty("LinkMealRecipe")]
        public virtual Recipe Recipe { get; set; }
    }
}
