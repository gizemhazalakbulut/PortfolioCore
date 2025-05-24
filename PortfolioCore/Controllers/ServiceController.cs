using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        public IActionResult DeleteService(int id)
        {
            var values = context.Services.Find(id);
            context.Services.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = context.Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            context.Services.Update(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}
