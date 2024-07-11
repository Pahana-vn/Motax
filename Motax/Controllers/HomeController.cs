using Microsoft.AspNetCore.Mvc;
using Motax.Models;
using System.Diagnostics;

namespace Motax.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("/404")]
        public IActionResult PageNotFound()
        {
            return View();
        }

    }
}
