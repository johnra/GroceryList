using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class RecipeCategoryLu
    {
        public RecipeCategoryLu()
        {
            Recipe = new HashSet<Recipe>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("RecipeCategory")]
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
