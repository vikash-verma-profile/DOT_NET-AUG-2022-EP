using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS.Models
{
    public partial class TblMenu
    {
        public int Id { get; set; }
        public string MenuText { get; set; }
        public string Link { get; set; }
        public int? ParentId { get; set; }
    }
}
