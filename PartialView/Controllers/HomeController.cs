using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialView.Models;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Products> products = new List<Products>()
            {
                new Products()
                {
                    Id=101,
                    Name="Imported Glasses",
                    Description="description",
                    Price=1200.00,
                    Image="~/Images/glass.jpeg"
                },
                 new Products()
                {
                    Id=102,
                    Name="Imported shoe",
                    Description="description 2",
                    Price=15000.00,
                    Image="~/Images/shoe.jpeg"
                },
                  new Products()
                {
                    Id=101,
                    Name="Imported Watch",
                    Description="description 3",
                    Price=10000.00,
                    Image="~/Images/watch.jpeg"
                }
            };
            return View(products);
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
