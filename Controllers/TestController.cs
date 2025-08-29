using Microsoft.AspNetCore.Mvc;
using PaymentManagementAPI.Data;

namespace PaymentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Base route: /api/test
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        // GET api/test/db
        [HttpGet("db")]
        public IActionResult CheckDatabase()
        {
            try
            {
                var canConnect = _context.Database.CanConnect();
                return Ok(new { DatabaseConnected = canConnect });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }
    }
}
