using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models.BuyBoost;

namespace MyApp.Controllers
{
    public class BuyBoostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult DivisionBoost(DivisionBoostModel model)
        {
            return View(nameof(Index), new IndexViewModel());
        }

        [HttpPost]
        public IActionResult WinsBoost(WinsBoostModel model)
        {
            return View(nameof(Index), new IndexViewModel());
        }
    }
}