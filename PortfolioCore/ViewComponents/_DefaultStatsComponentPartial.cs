using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.testimonialCount = context.Testimonials.Count();
            ViewBag.portfolioCount = context.Portfolios.Count();
            ViewBag.skillCount = context.Skills.Count();

            Random random = new Random();
            int randomNumber = random.Next(10, 20);
            ViewBag.RandomNumber = randomNumber;
            return View();
        }
    }
   
}
