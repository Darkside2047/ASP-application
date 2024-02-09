using Microsoft.AspNetCore.Mvc;

namespace WilliamBowensTutorialApp.Areas.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }

      
    }
