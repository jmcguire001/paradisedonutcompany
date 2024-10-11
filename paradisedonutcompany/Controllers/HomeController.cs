using Microsoft.AspNetCore.Mvc;
using paradisedonutcompany.Models;
using System.Diagnostics;

namespace paradisedonutcompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly IcecreamdonutsContext _context; // DbContext
        private readonly ILogger<HomeController> _logger;

        // Constructor with DbContext injection
        public HomeController(IcecreamdonutsContext context, ILogger<HomeController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // Ensure context is not null
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!_context.Database.CanConnect())
            {
                throw new Exception("Unable to connect to the database.");
            }

            var flavor = _context.Flavors.ToList();

            return View(flavor);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
