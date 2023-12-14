using DriversDevOps.Data;
using DriversDevOps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DriversDevOps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly DriverDbContext _context;

        public DriverController(DriverDbContext context)
        {
            _context = context;
        }
        [HttpGet(Name = "getdrivers")]
        public async Task<IActionResult> Get()
        {
            var driver = new Driver()
            {
                Id = new Guid("667a9b62-ee2c-4d0b-92c0-7ba7398e6643"),
                Name = "Dragos",
                Email = "dragos@gmail.com"
            };

            _context.Add(driver);
            await _context.SaveChangesAsync();
            var allDrivers = await _context.Drivers.ToListAsync();

            return Ok(allDrivers);
        }
    }
}
