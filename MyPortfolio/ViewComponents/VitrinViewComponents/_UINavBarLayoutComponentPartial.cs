using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.VitrinViewComponents
{
    public class _UINavBarLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
