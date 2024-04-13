using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _DefaultFooterSocialMediaLayoutComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _portfolioContext = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            return View(_portfolioContext.SocialMedias.ToList());
        }
    }
}
