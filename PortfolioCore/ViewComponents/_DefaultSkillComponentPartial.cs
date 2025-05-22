using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSkillComponentPartial : ViewComponent
    {
      PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var skill = context.Skills.ToList();
            return View(skill);
        }
    }
    
}
