using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.VitrinViewComponents
{
    public class _UIHeadLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
