using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class LinkRecipeAttribute
    {
        [Key]
        public long Id { get; set; }
        public Guid? RecipeId { get; set; }
        public long? AttributeId { get; set; }

        [ForeignKey(nameof(AttributeId))]
        [InverseProperty(nameof(RecipeAttributeLu.LinkRecipeAttribute))]
        public virtual RecipeAttributeLu Attribute { get; set; }
        [ForeignKey(nameof(RecipeId))]
        [InverseProperty("LinkRecipeAttribute")]
        public virtual Recipe Recipe { get; set; }
    }
}
