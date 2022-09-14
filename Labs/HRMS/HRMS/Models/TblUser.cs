using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Password { get; set; }
    }
}
