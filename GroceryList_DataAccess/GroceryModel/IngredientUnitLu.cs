using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_DataAccess.GroceryModel
{
    public partial class IngredientUnitLu
    {
        public IngredientUnitLu()
        {
            Ingredient = new HashSet<Ingredient>();
            LinkRecipeIngredient = new HashSet<LinkRecipeIngredient>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("DefaultUnit")]
        public virtual ICollection<Ingredient> Ingredient { get; set; }
        [InverseProperty("UnitNavigation")]
        public virtual ICollection<LinkRecipeIngredient> LinkRecipeIngredient { get; set; }
    }
}
