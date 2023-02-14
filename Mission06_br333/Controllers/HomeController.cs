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
        private MovieFormContext _formContext { get; set; }

        //Constructor. We now pass the _formContext too
        public HomeController(MovieFormContext name)
        {
            _formContext = name;
        }

        public IActionResult Index()
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

        //action for the Movie List page
        public IActionResult MovieList()
        {
            return View();
        }
    }
}
