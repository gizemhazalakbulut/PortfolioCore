using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class MessageController : Controller
    {

        PortfolioContext context = new PortfolioContext();

        public IActionResult MessageList()
        {
            var messages = context.Messages.ToList();
            return View(messages);
        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {
            // Bu kontrol kaldırıldı
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            context.Messages.Add(message);
            context.SaveChanges();

            TempData["MessageSent"] = true;
            // Aynı sayfada, contact section'a dön
            return Redirect("/Default#contact");
        }

        public IActionResult ChangeMessageIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }
        public IActionResult ChangeMessageIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }
        public IActionResult OpenMessage(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }
    }
}