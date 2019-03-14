using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var adminViewModel = new AdminViewModel { UserComment = "some comment from admin" };
            return View(adminViewModel);
        }
    }
}