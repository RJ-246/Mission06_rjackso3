using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_rjackso3.Models;

namespace Mission06_rjackso3.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieContext _movieContext { get; set; }
        

        public HomeController(MovieContext movieData)
        {
        
            _movieContext = movieData;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieData()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieData(NewMovieData entry)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(entry);
                _movieContext.SaveChanges();
                return View("Confirmation");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var data = _movieContext.Responses
                .Include(x => x.category)
                .ToList();
            return View(data);
        }

        public IActionResult Edit()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View("MovieData");
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}

