using Microsoft.AspNetCore.Mvc;
using EnderunYetimEvi.Models;
namespace EnderunYetimEvi.Controllers
{
    public class DormController:Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Donate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Donate(Donater model)
        {
            return View();
        }

        public IActionResult Students() 
        { 
            return View();
        }




    }
}
