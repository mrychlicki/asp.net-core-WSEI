﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEI_asp.netcore.Models.Response
{
    public class AddNewItemResponse
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }
        public bool success { get; set; }
    }
}
