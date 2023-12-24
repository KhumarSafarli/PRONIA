using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Entities;

namespace Pronia.Controllers
{
    public class PlantsController : Controller
    {
        private readonly ProniaDbContext _context;

        public PlantsController(ProniaDbContext context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {
            if (id == 0) return BadRequest();

            Plant plant = _context.Plants
                                    .Include(p => p.PlantInformations)
                                    .ThenInclude(p => p.Information)
                                    .Include(p => p.PlantCategories)
                                    .ThenInclude(pc => pc.Category)
                                    .Include(p => p.PlantImages)
                                    .Include(p =>p.PlantTags)
                                    .ThenInclude(pt => pt.Tag)
                                    .FirstOrDefault(p => p.Id == id)!;

            if (plant is null) return NotFound();

            return View(plant);
        }

        public IActionResult GetPlantsPartial(IEnumerable<Plant> Plants)
        {
            return PartialView("_PlantsPv", _context.Plants.Include(p => p.PlantImages).ToList());
        }
    }
}
