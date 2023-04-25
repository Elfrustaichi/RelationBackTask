using EternaTaskRelation.DataAccess;
using EternaTaskRelation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTaskRelation.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly EternaRelationContext _context;
        public PortfolioController(EternaRelationContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data =_context.Portfolios.Include(x=>x.Category).ToList();
            return View(data);
        }
        public IActionResult Details()
        {
            var data = _context.Portfolios.Include(x=>x.Category).ToList(); 
            return View(data);
        }
    }
}
