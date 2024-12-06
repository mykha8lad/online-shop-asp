using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Shop.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Страница регистрации
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Регистрация нового пользователя
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // Проверяем, существует ли уже пользователь
                var existingUser = _context.Users.FirstOrDefault(u => u.Username == model.Username);
                if (existingUser != null)
                {
                    ModelState.AddModelError(string.Empty, "Пользователь с таким именем уже существует.");
                    return View(model);
                }

                // Добавляем нового пользователя
                _context.Users.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        // Страница авторизации
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Авторизация пользователя
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Если пользователь найден, переходим на главную страницу
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Если нет такого пользователя, показываем ошибку
                ModelState.AddModelError(string.Empty, "Неверное имя пользователя или пароль.");
                return View();
            }
        }

        // Выход из системы
        public IActionResult Logout()
        {
            // Для выхода нужно будет использовать механизм авторизации
            return RedirectToAction("Index", "Home");
        }
    }
}
