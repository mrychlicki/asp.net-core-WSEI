using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_asp.netcore.Models
{
    public class FormModel
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

         
        public bool IsVisible { get; set; }

         
        public bool IsValid()
        {
            bool isNameValid = Name.Length > 0;
            bool isDescriptionValid = Description.Length > 0;
            return isNameValid && isDescriptionValid;
        }
    }
}
