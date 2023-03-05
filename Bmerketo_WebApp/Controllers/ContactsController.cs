using Bmerketo_WebApp.Models.Forms;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo_WebApp.Controllers
{
    public class Contacts : Controller
    {
        public IActionResult Index(string ReturnUrl = null!)
        {
            ViewData["Title"] = "Come in Contact with Us";
            var form = new ContactForm { ReturnUrl = ReturnUrl ?? Url.Content("~/") };
            return View(form);
        }

        [HttpPost]
        public IActionResult Index(ContactForm form)
        {
            return View();
        }
    }
}
