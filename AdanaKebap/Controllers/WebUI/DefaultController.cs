using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.Controllers.WebUI
{
    [Route("")]
    [Route("anasayfa")]
    public class DefaultController : Controller
    {
        
        
        public IActionResult Index1()
        {
            return View();
        }
    }
}
