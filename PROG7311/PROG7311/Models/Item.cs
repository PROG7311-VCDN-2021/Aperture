using System;
using System.Collections.Generic;

#nullable disable

namespace PROG7311.Models
{
    public partial class Item
    {
        public Item()
        {
            Carts = new HashSet<Cart>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Price { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
