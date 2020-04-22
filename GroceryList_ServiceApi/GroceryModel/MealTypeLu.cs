using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class MealTypeLu
    {
        public MealTypeLu()
        {
            Meal = new HashSet<Meal>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("MealType")]
        public virtual ICollection<Meal> Meal { get; set; }
    }
}
