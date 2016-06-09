using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace OnlinePortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        //Finns för att redirecta den gamla adressen www.mikaelbrunnberg.azurewebsites.net/portfolio/home till rätt sida 
        public IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
