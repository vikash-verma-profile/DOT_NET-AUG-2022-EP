using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.ViewModel
{
    public class LoginResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
    }
}
