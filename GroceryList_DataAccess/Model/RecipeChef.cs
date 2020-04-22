using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList
{
    public partial class RecipeChef
    {
        public RecipeChef()
        {
            Recipe = new HashSet<Recipe>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("RecipeChef")]
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
