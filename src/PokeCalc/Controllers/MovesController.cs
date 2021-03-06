﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeCalc.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PokeCalc.Controllers
{
    public class MovesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMoves(string searchQuery)
        {
            string lowercaseSearch = searchQuery.ToLower();
            var result = Move.GetMoves(lowercaseSearch);
            return Json(result);
        }
    }
}
