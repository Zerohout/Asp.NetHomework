﻿using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(ILogger logger)
        {

        }

        public async Task<IActionResult> Index()
        {
           return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }


        public IActionResult BlogSingle()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult ErrorStatus(string id)
        {
            if (id == "404")
                return RedirectToAction("NotFound");
            return Content($"Статуcный код ошибки: {id}");
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }
}