using System;
using System.Collections.Generic;

#nullable disable

namespace Customers
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }
}
