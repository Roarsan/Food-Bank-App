using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CW1_MVC_Food_Bank_Website.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
