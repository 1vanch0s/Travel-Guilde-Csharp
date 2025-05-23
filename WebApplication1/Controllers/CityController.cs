using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CitiesController : Controller
    {
        private readonly TravelGuideContext _context;

        public CitiesController(TravelGuideContext context)
        {
            _context = context;
        }

        // GET: Cities
        public async Task<IActionResult> Index(string searchString)
        {
            var cities = from c in _context.Cities
                         select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                cities = cities.Where(c => c.Name.Contains(searchString));
            }

            return View(await cities.ToListAsync());
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.Cities
                .Include(c => c.Attractions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }
    }
}
