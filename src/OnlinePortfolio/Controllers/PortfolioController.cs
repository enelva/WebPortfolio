using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Http;
using OnlinePortfolio.Models;
using OnlinePortfolio.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlinePortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: /<controller>/
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendAnEmail(MailSenderVM mailSenderVMThing) // Lägg in en VM för det!
        {
            MailSender mail = new MailSender();
            mail.SendMail(mailSenderVMThing.Name, mailSenderVMThing.Subject, mailSenderVMThing.Email, mailSenderVMThing.Message); //From, Subject, Email, Text
            ViewData["mail_succes"] = "1";
            return RedirectToAction(nameof(PortfolioController.Home));
        }

    }
}
