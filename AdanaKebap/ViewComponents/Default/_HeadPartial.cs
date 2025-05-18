using Microsoft.AspNetCore.Mvc;

namespace AdanaKebap.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
