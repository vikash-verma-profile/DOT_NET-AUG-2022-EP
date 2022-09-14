using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.ViewModel
{
    public class Login
    {
        [Required(ErrorMessage = "UserName is Mandatory")]
       // [StringLength(2,ErrorMessage ="length is greater than 2")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Mandatory")]
        public string Password { get; set; }
    }
}
