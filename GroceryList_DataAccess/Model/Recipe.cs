using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList
{
    public partial class Recipe
    {
        [Key]
        public long Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public int Servings { get; set; }
        public int PrepTime { get; set; }
        public int Stars { get; set; }
        public int? RecipeCategoryId { get; set; }
        public int? RecipeTypeId { get; set; }
        [StringLength(100)]
        public string Reference { get; set; }
        public int? RecipeChefId { get; set; }

        [ForeignKey(nameof(RecipeCategoryId))]
        [InverseProperty("Recipe")]
        public virtual RecipeCategory RecipeCategory { get; set; }
        [ForeignKey(nameof(RecipeChefId))]
        [InverseProperty("Recipe")]
        public virtual RecipeChef RecipeChef { get; set; }
        [ForeignKey(nameof(RecipeTypeId))]
        [InverseProperty("Recipe")]
        public virtual RecipeType RecipeType { get; set; }
    }
}
