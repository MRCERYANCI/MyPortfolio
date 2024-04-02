using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _SkillDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
