﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp1.Models
{
    public partial class TblUserDetail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
    }
}
