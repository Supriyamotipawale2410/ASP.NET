using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class SIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SI obj)
        {
            ViewBag.result= "Simple Interest : " + (obj.P * obj.T * obj.T)/100;
            return View();
        }
    }
}
