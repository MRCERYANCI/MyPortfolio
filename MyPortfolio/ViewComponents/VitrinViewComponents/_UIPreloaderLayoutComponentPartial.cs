using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.VitrinViewComponents
{
    public class _UIPreloaderLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
