using Microsoft.AspNetCore.Mvc;

namespace EnglishMan.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()=>View();
        public IActionResult About()=>View();
        
    }
}
