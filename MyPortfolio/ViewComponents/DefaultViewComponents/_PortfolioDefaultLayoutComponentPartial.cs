using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _PortfolioDefaultLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
