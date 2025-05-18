using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.ViewComponents.Default
{
    public class _ServicePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
