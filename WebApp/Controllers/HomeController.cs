using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(Movie model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Save changes
        //        return RedirectToAction(nameof(Index));
        //    }
        //    else
        //    {
        //        return View(model);
        //    }            
        //}


        [HttpPost]
        [ValidateModel]
        public IActionResult Create(Movie model)
        {
            // Save changes
            return RedirectToAction(nameof(Index));
        }

    }
}
