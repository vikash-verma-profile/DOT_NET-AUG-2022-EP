using System;
using System.Collections.Generic;

#nullable disable

namespace Day_11.Models
{
    public partial class Product
    {
        public int? Id { get; set; }
        public decimal? FinalAmount { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? Discount { get; set; }
        public string Productname { get; set; }
        public string ProductDescription { get; set; }
    }
}
