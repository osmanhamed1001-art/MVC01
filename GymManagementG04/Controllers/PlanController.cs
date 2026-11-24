using GymManagementG04.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagementG04.Controllers
{
    public class PlanController : Controller
    {
        //    public IActionResult Text()
        //    { return View(); }
        public async Task<IActionResult> Index()
        {
            //Plan/Index
          GymDbContext context = new GymDbContext();
            var plans =await context.Plans.ToListAsync();
            return View(plans);

        
        }
    }
}
