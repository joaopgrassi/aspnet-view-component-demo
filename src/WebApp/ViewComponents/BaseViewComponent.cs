using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.ViewComponents
{
    public class BaseViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(BaseViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
