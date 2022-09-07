using System;
using System.Collections.Generic;

#nullable disable

namespace Day_11.Models
{
    public partial class TblOrder
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int? CutomerId { get; set; }

        public virtual Customer Cutomer { get; set; }
    }
}
