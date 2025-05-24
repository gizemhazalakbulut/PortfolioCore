using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class EducationController : Controller
    {
        PortfolioContext context = new();
        public IActionResult EducationList()
        {
            var educationList = context.Educations.ToList();
            return View(educationList);
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var education = context.Educations.Find(id);
            return View(education);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            context.Educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }

        public IActionResult DeleteEducation(int id)
        {
            var education = context.Educations.Find(id);
            context.Educations.Remove(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
