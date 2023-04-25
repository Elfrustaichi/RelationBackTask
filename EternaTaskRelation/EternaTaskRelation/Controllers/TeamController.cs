using EternaTaskRelation.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTaskRelation.Controllers
{
    public class TeamController : Controller
    {
        private readonly EternaRelationContext _context;

        public TeamController(EternaRelationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data =_context.TeamMembers.Include(x=>x.Position).ToList(); 
            return View(data);
        }
    }
}
