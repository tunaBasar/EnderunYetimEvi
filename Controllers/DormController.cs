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
            return View("StudentList",model);
        }




    }
}
