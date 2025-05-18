using Microsoft.AspNetCore.Mvc;
using AdanaKebap.Context;
using Microsoft.EntityFrameworkCore;

namespace AdanaKebap.Controllers.WebUI
{
    public class BookingController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
