using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WilliamBowensTutorialApp.Models;

namespace WilliamBowensTutorialApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //Routing test for the index method

        [Route("topic/{topic}/category/{category}")]
       
        [Route("topic/{topic}")]
       
        [Route("category/{category}")]
       
        [Route("")]
        public IActionResult Index(string? topic = null, string? category = null)
          {
            return View();
        }


        //About and contact methods added here

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }


        //Contact form validation controller here
        [HttpPost]
        public IActionResult SubmitContact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the form (e.g., save data, send email)
                return RedirectToAction("Success");
            }

            return View("Contact", model); // Return with validation messages
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}