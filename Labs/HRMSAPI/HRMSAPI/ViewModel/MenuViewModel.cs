using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMSAPI.ViewModel
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public string MenuText { get; set; }
        public string Link { get; set; }
        public int ParentID { get; set; }
    }
}
