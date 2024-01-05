using CW1_MVC_Food_Bank_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace CW1_MVC_Food_Bank_Website.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ILogger<DetailsController> _logger;

        public DetailsController(ILogger<DetailsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Details()
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