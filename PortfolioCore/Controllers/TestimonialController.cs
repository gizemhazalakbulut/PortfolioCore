﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial p)
        {
            context.Testimonials.Add(p);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var p = context.Testimonials.Find(id);
            context.Testimonials.Remove(p);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial p)
        {
            context.Testimonials.Update(p);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
