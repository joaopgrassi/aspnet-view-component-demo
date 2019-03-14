using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var userViewModel = new UserViewModel { UserComment = "some comment from the user" };
            return View(userViewModel);
        }
    }
}