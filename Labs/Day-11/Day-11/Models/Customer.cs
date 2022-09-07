using System;
using System.Collections.Generic;

#nullable disable

namespace Day_11.Models
{
    public partial class Customer
    {
        public Customer()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public int? Age { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
