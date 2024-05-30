using Bubblehop.DataAccess.DataRepository.RepositoryInterface;
using Bubblehop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BubblehopWeb.Areas.User.Controllers
{
    [Area("User")]
    public class TravelPlanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TravelPlanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


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
            if(ModelState.IsValid)
            {
                _unitOfWork.TravelPlan.AddWithAsync(plan);
            }

            return View();
        }
    }
}
