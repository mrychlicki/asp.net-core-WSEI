using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_asp.netcore.Models;

namespace WSEI_asp.netcore.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            CompanyAddedViewModel viewModel = new CompanyAddedViewModel
            {
                NumberOfCharInName = company.Name.Length,
                NumberOfCharInDescription = company.Description.Length,
                IsHidden = !company.IsVisible

            };
            return View("CompanyAdded", viewModel);
        }
    }
}
