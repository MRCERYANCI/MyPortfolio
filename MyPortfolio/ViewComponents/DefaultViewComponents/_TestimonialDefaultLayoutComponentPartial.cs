using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _TestimonialDefaultLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
