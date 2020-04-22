using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList
{
    public partial class IngredientCategory
    {
        public IngredientCategory()
        {
            Ingredient = new HashSet<Ingredient>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Ingredient> Ingredient { get; set; }
    }
}
