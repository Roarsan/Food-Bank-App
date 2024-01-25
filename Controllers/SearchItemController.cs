using CW1_MVC_Food_Bank_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CW1_MVC_Food_Bank_Website.Controllers
{
    public class SearchItemController : Controller
    {
        private readonly ILogger<SearchItemController> _logger;

        public SearchItemController(ILogger<SearchItemController> logger)
        {
            _logger = logger;
        }

        public IActionResult Admin()
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
