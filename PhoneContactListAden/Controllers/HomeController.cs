using Microsoft.AspNetCore.Mvc;
using PhoneContactListAden.Models;
using System.Diagnostics;

namespace PhoneContactListAden.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext cxt)
        {
            context = cxt;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View();
        }
    }
}