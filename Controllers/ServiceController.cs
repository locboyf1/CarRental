﻿using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}