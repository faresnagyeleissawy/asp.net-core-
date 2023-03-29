using EVC_DAY2.Context;
using EVC_DAY2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EVC_DAY2.Controllers
{
    public class InstructorController : Controller
    {
        DepartmentContex context = new DepartmentContex();
        public IActionResult Index()
        {
            List<Instructor> InstructorModel = context.instructors.ToList();
            return View("Index", InstructorModel);
        }
        public IActionResult Details(int id)//,string name)
        {
            List<Instructor> Instructors = context.instructors.ToList();
            Instructor? InstructorsModel = Instructors.FirstOrDefault(s => s.Id == id);
            return View("Details", InstructorsModel);
        }
    }
}
