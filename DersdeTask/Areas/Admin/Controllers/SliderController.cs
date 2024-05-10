using Microsoft.AspNetCore.Mvc;

namespace DersdeTask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update() {
            return View();
        }
    }
}
