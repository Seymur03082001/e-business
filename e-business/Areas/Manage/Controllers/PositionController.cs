using e_business.DAL;
using e_business.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_business.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PositionController : Controller
    {
        public readonly AppDbContext _context;
        public PositionController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Positions);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Position position)
        {
            if (position == null) return BadRequest();
            if (!ModelState.IsValid) return View();
            Position position1 = new Position
            { 
                Name= position.Name,
            };
            await _context.Positions.AddAsync(position1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if(id== null) return BadRequest();
        //    var posit = 
        //}
    }
}
