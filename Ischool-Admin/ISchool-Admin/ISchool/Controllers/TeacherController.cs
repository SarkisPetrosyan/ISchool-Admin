using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.DAL.Context;

namespace ISchool.Controllers
{
    public class TeacherController : BaseController
    {
        public TeacherController(IDbContext context) : base(context)
        {

        }

        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
    }
}