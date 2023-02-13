using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_br333.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_br333.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext _formContext { get; set; }

        //Constructor. We now pass the _formContext too
        public HomeController(ILogger<HomeController> logger, MovieFormContext name)
        {
            _logger = logger;
            _formContext = name;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //This action displays the Podcast Page
        public IActionResult Podcast()
        {
            return View();
        }

        //These 2 actions display the Movie Form Page
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            //set condition to check for valid form input so the program
            if (ModelState.IsValid)
            {
                //add and save data to the DB
                _formContext.Add(fr);
                _formContext.SaveChanges();
                //return the confirmation page view
                return View("Confirmation", fr);
            }
            else
            {
                return View(fr);
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
