using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.Controllers.WebUI
{
    public class _UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
