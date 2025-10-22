using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.Controllers.WebUI
{
    public class ServiceController : Controller
    {
        [Route("hizmetler")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
