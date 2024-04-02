using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.VitrinViewComponents
{
    public class _UIScriptsLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
