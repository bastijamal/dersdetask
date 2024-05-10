
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DersdeTask.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

      

    }
}