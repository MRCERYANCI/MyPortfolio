using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _AboutDefaultLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
