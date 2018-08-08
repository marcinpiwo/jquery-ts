using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class FooController : Controller
    {
        public IActionResult Index()
        {
            return View(new FooViewModel());
        }

        [HttpPost]
        public IActionResult Index(SubModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Index2(Sub2Model viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), new FooViewModel(viewModel));
            }

            return RedirectToAction("Index", "Home");
        }

    }
}