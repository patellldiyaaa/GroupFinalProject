using Microsoft.AspNetCore.Mvc;

namespace GroupFinalProject.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Favorites()
        {
            return View();
        }
    }
}