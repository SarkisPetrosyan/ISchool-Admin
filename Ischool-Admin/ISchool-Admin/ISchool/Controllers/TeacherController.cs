using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.DAL.Context;
using ISchool.Service.Services;

namespace ISchool.Controllers
{
    public class TeacherController : BaseController
    {
        private Lazy<ITeacherService> _teacherService;
        public TeacherController(IDbContext context, ITeacherService teacherService) : base(context)
        {
            _teacherService = new Lazy<ITeacherService>(() => teacherService);
        }

        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
    }
}