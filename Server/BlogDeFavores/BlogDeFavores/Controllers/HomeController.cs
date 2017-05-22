using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("/api/asd")]
        public IActionResult About([FromBody] Usuario usuario)
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
