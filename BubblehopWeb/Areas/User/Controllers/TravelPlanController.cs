using BubblehopWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BubblehopWeb.Areas.User.Controllers
{
    [Area("User")]
    public class TravelPlanController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePlan()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePlan(TravelPlan plan)
        {
            return View();
        }
    }
}
