using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.VitrinViewComponents
{
    public class _UIFooterLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
