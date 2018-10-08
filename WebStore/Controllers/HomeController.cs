﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Interfaces.Api;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValuesService _valuesService;

        public HomeController(IValuesService valuesService)
        {
            _valuesService = valuesService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _valuesService.GetAsync();
            return View(values);
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

        public IActionResult NotFound()
        {
            return View();
        }
    }
}