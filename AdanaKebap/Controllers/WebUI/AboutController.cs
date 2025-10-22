using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.Controllers.WebUI
{
    public class AboutController : Controller
    {
        [Route("Hakkimizda")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
