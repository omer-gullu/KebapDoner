using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.Controllers.WebUI
{
    public class MenuController : Controller
    {
        [Route("menu")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
