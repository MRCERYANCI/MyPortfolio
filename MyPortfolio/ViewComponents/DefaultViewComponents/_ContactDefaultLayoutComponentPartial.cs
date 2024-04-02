using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _ContactDefaultLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
