using Microsoft.AspNetCore.Mvc;

namespace WilliamBowensTutorialApp.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(int id)
        {
           
            switch (id)
            {
                case 1:
                    return View("Page1");
                case 2:
                    return View("Page2");
                case 3:
                    return View("Page3");
                default:
                    return NotFound(); 
            }
        }

        public IActionResult Page2()
        {
            return View();
        }
    }
}
