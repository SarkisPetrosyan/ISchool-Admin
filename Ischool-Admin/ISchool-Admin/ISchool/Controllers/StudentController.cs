

using ISchool.DAL.Context;
using ISchool.Service.Services;
using System;
using System.Web.Mvc;

namespace ISchool.Controllers
{
    public class StudentController : BaseController
    {
        private Lazy<IStudentService> _studentService;
        public StudentController(IDbContext context, IStudentService studentService) : base(context)
        {
            _studentService = new Lazy<IStudentService>(() => studentService);
        }

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}