using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryList
{
    public partial class IngredientSource
    {
        [Key]
        public long Id { get; set; }
        [StringLength(75)]
        public string Name { get; set; }
        public bool IsLocal { get; set; }
        public bool IsRegional { get; set; }
        public bool IsOnline { get; set; }
        [StringLength(50)]
        public string LocalAddress1 { get; set; }
        [StringLength(50)]
        public string LocalAddress2 { get; set; }
        [StringLength(50)]
        public string LocalCity { get; set; }
        [StringLength(50)]
        public string LocalState { get; set; }
        [StringLength(50)]
        public string LocalEmail { get; set; }
        [StringLength(15)]
        public string LocalPhone { get; set; }
        [StringLength(50)]
        public string RegionalAddress1 { get; set; }
        [StringLength(50)]
        public string RegionalAddress2 { get; set; }
        [StringLength(50)]
        public string RegionalCity { get; set; }
        [StringLength(50)]
        public string RegionalState { get; set; }
        [StringLength(50)]
        public string RegionalEmail { get; set; }
        [StringLength(15)]
        public string RegionalPhone { get; set; }
        [StringLength(75)]
        public string OnlineAddress1 { get; set; }
    }
}
