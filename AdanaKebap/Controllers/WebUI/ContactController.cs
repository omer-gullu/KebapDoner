using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.Controllers.WebUI
{
    public class ContactController : Controller
    {
        [Route("iletisim")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
