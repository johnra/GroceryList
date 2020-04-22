using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_DataAccess.GroceryModel
{
    public partial class RecipeTypeLu
    {
        public RecipeTypeLu()
        {
            Recipe = new HashSet<Recipe>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("RecipeType")]
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
