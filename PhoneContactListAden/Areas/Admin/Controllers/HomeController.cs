using Microsoft.AspNetCore.Mvc;
using PhoneContactListAden.Models;

namespace PhoneContactListAden.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx) =>
            context = ctx;
        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(
                c => c.Name).ToList();
            return View(contacts);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
