using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.DAL.Context;

namespace ISchool.Controllers
{
    public class LessonController : BaseController
    {
        public LessonController(IDbContext context) : base(context)
        {
        }

        // GET: Lesson
        public ActionResult Index()
        {
            return View();
        }
    }
}