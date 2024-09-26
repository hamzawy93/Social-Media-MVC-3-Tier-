using Microsoft.AspNetCore.Mvc;
using Social_Media.BLL.Service.Abstraction;
using Social_Media.BLL.Service.Implmentation;
using Social_Media.DAL.Entity;

namespace Social_Media.Controllers
{
    public class UserController : Controller
    {
        IUserService userService = new UserService();

        public IActionResult Index()
        {
            return View(userService.GetUsers());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(User user)
        {
            userService.Create(user);
            return RedirectToAction("Index");

        }
    }
}