using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_DataAccess.GroceryModel
{
    public partial class LinkRecipeIngredient
    {
        [Key]
        public long Id { get; set; }
        public Guid? RecipeId { get; set; }
        public long? IngredientId { get; set; }
        [StringLength(50)]
        public string Size { get; set; }
        public double? Quantity { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }
        public long? UnitId { get; set; }

        [ForeignKey(nameof(IngredientId))]
        [InverseProperty("LinkRecipeIngredient")]
        public virtual Ingredient Ingredient { get; set; }
        [ForeignKey(nameof(RecipeId))]
        [InverseProperty("LinkRecipeIngredient")]
        public virtual Recipe Recipe { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(IngredientUnitLu.LinkRecipeIngredient))]
        public virtual IngredientUnitLu UnitNavigation { get; set; }
    }
}
