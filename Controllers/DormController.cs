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
            Repository.Add(model);
            return View("DonaterFeedBack",model);
        }

        public IActionResult Students() 
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Students(Student model)
        {
            Repository.AddStudent(model);
            return View("Studentregistiration", model);
        }

        public IActionResult DonaterList()
        {
            var model = Repository.donaters_;
            return View("DonaterList",model);
        }

        public IActionResult orphans()
        {
            var model = Repository.students_;
            return View("orphans",model);
        }
       


    }
}
