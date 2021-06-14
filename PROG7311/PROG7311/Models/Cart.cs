using System;
using System.Collections.Generic;

#nullable disable

namespace PROG7311.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int? Quantity { get; set; }
        public int? ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
