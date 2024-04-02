using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _FeatureDefaultLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
