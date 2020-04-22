using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList_ServiceApi.GroceryModel
{
    public partial class User
    {
        [Key]
        [StringLength(150)]
        public string Username { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
    }
}
