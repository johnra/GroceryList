using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            LinkRecipeIngredient = new HashSet<LinkRecipeIngredient>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public long? IngredientTypeId { get; set; }
        public long? IngredientCategoryId { get; set; }
        public long? DefaultUnitId { get; set; }
        public double? GmConversion { get; set; }

        [ForeignKey(nameof(DefaultUnitId))]
        [InverseProperty(nameof(IngredientUnitLu.Ingredient))]
        public virtual IngredientUnitLu DefaultUnit { get; set; }
        [ForeignKey(nameof(IngredientCategoryId))]
        [InverseProperty(nameof(IngredientCategoryLu.Ingredient))]
        public virtual IngredientCategoryLu IngredientCategory { get; set; }
        [ForeignKey(nameof(IngredientTypeId))]
        [InverseProperty(nameof(IngredientTypeLu.Ingredient))]
        public virtual IngredientTypeLu IngredientType { get; set; }
        [InverseProperty("Ingredient")]
        public virtual ICollection<LinkRecipeIngredient> LinkRecipeIngredient { get; set; }
    }
}
