using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbcontext context=new ApplicationDbcontext();
        public IActionResult Index()
        {
            var employee = context.Employees.ToList();
            return View("index",employee);
        }
    }
}
