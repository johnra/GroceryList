using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_DataAccess.GroceryModel
{
    public partial class RecipeAttributeLu
    {
        public RecipeAttributeLu()
        {
            LinkRecipeAttribute = new HashSet<LinkRecipeAttribute>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("Attribute")]
        public virtual ICollection<LinkRecipeAttribute> LinkRecipeAttribute { get; set; }
    }
}
