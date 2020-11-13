using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_asp.netcore.Models;
using WSEI_asp.netcore.Models.Response;

namespace WSEI_asp.netcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : ControllerBase
    {
       
        public AddNewItemResponse post(FormModel formmodel)
        {
            return new AddNewItemResponse
            {
                Description = formmodel.Description,
                Name = formmodel.Name,
                IsVisible = formmodel.IsVisible,
                success = true/**/
            };
        }
    }
}
