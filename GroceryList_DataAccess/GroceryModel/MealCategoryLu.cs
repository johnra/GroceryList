using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_DataAccess.GroceryModel
{
    public partial class MealCategoryLu
    {
        public MealCategoryLu()
        {
            Meal = new HashSet<Meal>();
        }

        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("MealCategory")]
        public virtual ICollection<Meal> Meal { get; set; }
    }
}
