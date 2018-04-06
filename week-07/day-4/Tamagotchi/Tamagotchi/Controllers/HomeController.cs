﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        IFroggy frogger;

        public HomeController (IFroggy frogger)
        {
            this.frogger = frogger;
        }
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            
            return View(frogger);
        }
        [HttpGet]
        [Route("")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        public IActionResult Login(string givenName)
        {
            frogger.SetName(givenName);
            return RedirectToAction("index");
        }
        [HttpPost]
        [Route("trick")]
        public IActionResult Trick(int i)
        {
            frogger.DoTrick(i);
            return RedirectToAction("index");
        }
        [HttpGet]
        [Route("trickstore")]
        public IActionResult TrickStore()
        {
            return View(frogger);
        }
        [HttpGet]
        [Route("nutritionstore")]
        public IActionResult NutritionStore()
        {
            return View(frogger);
        }
        [HttpGet]
        [Route("addfood")]
        public IActionResult AddFood(int i)
        {
            frogger.AddFood(i);
            return RedirectToAction("nutritionstore");
        }
        [HttpGet]
        [Route("adddrink")]
        public IActionResult AddDrink(int i)
        {
            frogger.AddDrink(i);
            return RedirectToAction("nutritionstore");
        }
        [HttpGet]
        [Route("addtrick")]
        public IActionResult AddTrick(int i)
        {
            frogger.AddTrick(i);
            return RedirectToAction("trickstore");
        }
    }
}
