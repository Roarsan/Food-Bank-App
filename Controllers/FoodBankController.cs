using CW1_MVC_Food_Bank_Website.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CW1_MVC_Food_Bank_Website.Controllers
{
    public class FoodBankController : Controller
    {
        private readonly FoodBankService _foodBankService;

        public FoodBankController(FoodBankService foodBankService)
        { 
            _foodBankService = foodBankService;
        }
        public async Task<IActionResult> Details()
        {
            var foodbank = await _foodBankService.GetFoodBanksAsync();
            return View(foodbank);
        }
    }
}
