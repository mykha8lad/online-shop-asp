﻿using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class ShoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}