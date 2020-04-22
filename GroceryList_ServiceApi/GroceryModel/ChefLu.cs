using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class ChefLu
    {
        [Key]
        public long Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(350)]
        public string Reference { get; set; }
    }
}
