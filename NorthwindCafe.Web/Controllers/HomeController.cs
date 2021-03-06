﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NorthwindCafe.Web.Data;

namespace NorthwindCafe.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _repository;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET: //
        public IActionResult Index()
        {
            var products = _repository.GetProducts();

            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}