using Microsoft.AspNetCore.Mvc;
using EVC_DAY2.Context;
using EVC_DAY2.Models;
namespace EVC_DAY2.Controllers

{
  


    public class DepartmentController : Controller
    {
        DepartmentContex context = new DepartmentContex();
        public IActionResult Index()
        {
            List <Department> departmentModel = context.Departments.ToList();   
            return View("Index",departmentModel);
        }
    }
}
