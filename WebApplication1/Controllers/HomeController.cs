using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEnumerable<ExampleModel> _models;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            _models = Enumerable.Range(1, 10).Select(i => new ExampleModel
            {
                Name = Guid.NewGuid().ToString(),
            });
        }

        public IActionResult Index()
        {
            // 데이터를 넣어줘야 합니다.
            return View(_models);
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
