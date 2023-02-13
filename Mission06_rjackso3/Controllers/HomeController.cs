using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_rjackso3.Models;

namespace Mission06_rjackso3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext movieData)
        {
            _logger = logger;
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

