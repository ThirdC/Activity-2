using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ListDbContext _context;

        public HomeController(ILogger<HomeController> logger, ListDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var allList = _context.Lists.ToList();
            return View(allList);
        }

        public IActionResult StudioGhibli()
        {
            return View();
        }

        public IActionResult CreateEditList()
        {
            return View();
        }

        public IActionResult CreateEditListForm(List model)
        {
            _context.Lists.Add(model);

            _context.SaveChanges();

            return RedirectToAction("List");
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
