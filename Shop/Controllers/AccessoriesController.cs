using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class AccessoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}