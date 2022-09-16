using System;
using System.Collections.Generic;

#nullable disable

namespace HRMSAPI.Models
{
    public partial class TblRoleMenuMapping
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
    }
}
