using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Statistic : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Destinations.Count();
            ViewBag.v2 = context.Guides.Count();
            ViewBag.v3 = "267";
            return View();
        }
    }
}
