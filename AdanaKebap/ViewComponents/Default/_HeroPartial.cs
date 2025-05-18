using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.ViewComponents.Default
{
    public class _HeroPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
