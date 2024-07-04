using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature2:ViewComponent
    {
      private readonly IFeature2Service _service;

        public _Feature2(IFeature2Service service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _service.TGetList();
            return View(values);
        }
    }
}
