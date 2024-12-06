using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Shop.Controllers
{
    public class AccountController : Controller
    {        
        public IActionResult Register()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }     
    }
}
