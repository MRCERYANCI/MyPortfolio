using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _StatisticsDefaultLayoutComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _portfolioContext = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.TestimonialCount = _portfolioContext.Testimonials.Count();
            ViewBag.ProjectCount = _portfolioContext.Portfolios.Count();
            ViewBag.ExperienceCount = _portfolioContext.Experiences.Count();
            ViewBag.MessageCount = 0;
            return View();
        }
    }
}
