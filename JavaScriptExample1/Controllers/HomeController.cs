using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JavaScriptExample1.Models;

namespace JavaScriptExample1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Product()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Product(Product p)
        {
            //validate server-side (back-end)
            //Can use data annotations etc in the model class
            //This is our final and safest check on data

            //The client-side validation tries to limit unnecessary server load
            //And the time the user has to wait for response
            
            //put info into DB here

            return View("ProductSuccess", p);
        }
        [HttpGet]
        public IActionResult UserForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserForm(User u)
        {

            return View("UserSuccess", u);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
