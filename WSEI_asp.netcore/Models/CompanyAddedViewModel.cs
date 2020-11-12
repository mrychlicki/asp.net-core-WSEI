using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_asp.netcore.Models
{
    public class CompanyAddedViewModel
    {
        public int NumberOfCharInName { get; set; }
        public int NumberOfCharInDescription { get; set; }
        public bool IsHidden { get; set; }
    }
}
