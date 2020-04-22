using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_DataAccess.GroceryModel
{
    public partial class IngredientCategoryLu
    {
        public IngredientCategoryLu()
        {
            Ingredient = new HashSet<Ingredient>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("IngredientCategory")]
        public virtual ICollection<Ingredient> Ingredient { get; set; }
    }
}
