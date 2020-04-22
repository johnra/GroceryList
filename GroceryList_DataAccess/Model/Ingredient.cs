using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList
{
    public partial class Ingredient
    {
        [Key]
        public long Id { get; set; }
        [StringLength(75)]
        public string Name { get; set; }
        public int? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(IngredientCategory.Ingredient))]
        public virtual IngredientCategory Category { get; set; }
    }
}
