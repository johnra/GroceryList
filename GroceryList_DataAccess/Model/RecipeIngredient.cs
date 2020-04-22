using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList
{
    public partial class RecipeIngredient
    {
        public long? Id { get; set; }
        public long? RecipeId { get; set; }
        public long? IngredientId { get; set; }
        [StringLength(50)]
        public string Size { get; set; }
        public double Quantity { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }

        [ForeignKey(nameof(IngredientId))]
        public virtual Ingredient Ingredient { get; set; }
        [ForeignKey(nameof(RecipeId))]
        public virtual Recipe Recipe { get; set; }
    }
}
