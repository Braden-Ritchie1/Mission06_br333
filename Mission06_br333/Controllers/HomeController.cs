using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _formContext.category.ToList();
            return View(new FormResponse());
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
                ViewBag.Categories = _formContext.category.ToList();
                return View(fr);
            }

        }

        //action for the Movie List page
        public IActionResult MovieList()
        {
            var apps = _formContext.responses
                .Include(x => x.Category)
                .ToList();

            return View(apps);
        }

        //Edit Action
        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.Categories = _formContext.category.ToList();

            var app = _formContext.responses.Single(x => x.FormID == id);

            return View("MovieForm", app);
        }

        [HttpPost]
        public IActionResult Edit (FormResponse fr2)
        {
            if (ModelState.IsValid)
            {
                _formContext.Update(fr2);
                _formContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _formContext.category.ToList();
                return View(fr2);
            }
        }

        //Delete Action
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var app = _formContext.responses.Single(x => x.FormID == id);

            return View(app);
        }

        [HttpPost]
        public IActionResult Delete(FormResponse fr3)
        {
            _formContext.responses.Remove(fr3);
            _formContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
