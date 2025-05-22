using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
         PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var lastSixServices = context.Services
      .OrderByDescending(s => s.ServiceId)
      .Take(6)
      .ToList();
            return View(lastSixServices);
        }
    }
    
}
