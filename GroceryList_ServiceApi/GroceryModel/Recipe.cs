using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class Recipe
    {
        public Recipe()
        {
            LinkMealRecipe = new HashSet<LinkMealRecipe>();
            LinkRecipeAttribute = new HashSet<LinkRecipeAttribute>();
            LinkRecipeIngredient = new HashSet<LinkRecipeIngredient>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        public int? ServingsMin { get; set; }
        public int? ServingsMax { get; set; }
        public int? PrepTime { get; set; }
        public int? CookTime { get; set; }
        public int? Stars { get; set; }
        [StringLength(250)]
        public string Reference { get; set; }
        [StringLength(500)]
        public string Link { get; set; }
        [StringLength(2500)]
        public string Description { get; set; }
        [Column(TypeName = "image")]
        public byte[] Image { get; set; }
        public long? ChefId { get; set; }
        public long? RecipeCategoryId { get; set; }
        public long? RecipeTypeId { get; set; }

        [ForeignKey(nameof(RecipeCategoryId))]
        [InverseProperty(nameof(RecipeCategoryLu.Recipe))]
        public virtual RecipeCategoryLu RecipeCategory { get; set; }
        [ForeignKey(nameof(RecipeTypeId))]
        [InverseProperty(nameof(RecipeTypeLu.Recipe))]
        public virtual RecipeTypeLu RecipeType { get; set; }
        [InverseProperty("Recipe")]
        public virtual ICollection<LinkMealRecipe> LinkMealRecipe { get; set; }
        [InverseProperty("Recipe")]
        public virtual ICollection<LinkRecipeAttribute> LinkRecipeAttribute { get; set; }
        [InverseProperty("Recipe")]
        public virtual ICollection<LinkRecipeIngredient> LinkRecipeIngredient { get; set; }
    }
}
