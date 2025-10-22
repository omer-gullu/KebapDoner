using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.ViewComponents.Default
{
    public class _BookingPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
