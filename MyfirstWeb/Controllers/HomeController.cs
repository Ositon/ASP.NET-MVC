using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyfirstWeb.Models;

namespace MyfirstWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            Models.Movie movie = new Models.Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View(movie);
        }

        //[Route("Home/About")]
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Notas()
        {
            return View();
        }

        // [Route("Contacto")]
        public ActionResult Contacto()
        {
            return View();
        }
        //_______________Model Binding_________________
        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View(new WebUser() { FirstName = "John", LastName = "Doe" });
        }
        [HttpPost]
        public IActionResult SimpleBinding(WebUser webUser)
        {
            //TODO: Update in DB here...
            return Content($"User {webUser.FirstName} updated!");
        }
        //___________________Agregando validación básica__________________________
        
        [HttpGet]
        public IActionResult SimpleValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleValidation(WebUser webUser)
        {
            if (ModelState.IsValid)
                return Content("Thank you!");
            else
                //return Content("Model could not be validated!");
                return View(webUser);
        }

    }
}