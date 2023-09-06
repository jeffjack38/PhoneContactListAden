using Microsoft.AspNetCore.Mvc;
using PhoneContactListAden.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace PhoneContactListAden.Controllers
{
    public class ContactController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;   
        private ContactContext context {  get; set; }

        public ContactController(ILogger<HomeController> logger, ContactContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts
                .OrderBy(m => m.Name)
                .ToList();

            return View(contacts);
        }


    }
}
