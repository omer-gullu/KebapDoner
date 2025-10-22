using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.Controllers.WebUI
{
    public class TestimonialController : Controller
    {
        [Route("musteri-gorusleri")]
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
