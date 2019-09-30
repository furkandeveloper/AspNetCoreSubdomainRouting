using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SubDomainService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string tenant)
        {
            return View();
        }
    }
}