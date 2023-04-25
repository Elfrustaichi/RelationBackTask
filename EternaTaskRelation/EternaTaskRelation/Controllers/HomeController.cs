using EternaTaskRelation.DataAccess;
using EternaTaskRelation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaTaskRelation.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaRelationContext _context;
        public HomeController(EternaRelationContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList(),


            };
            return View(homeViewModel);
        }
    }
}
