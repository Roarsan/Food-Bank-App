using CW1_MVC_Food_Bank_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;  // Add this line for ILogger

namespace CW1_MVC_Food_Bank_Website.Controllers
{
    public class FoodBankController : Controller
    {
        private readonly ILogger<FoodBankController> _logger;

        public FoodBankController(ILogger<FoodBankController> logger)
        {
            _logger = logger;
        }

        public IActionResult FoodBankList()
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