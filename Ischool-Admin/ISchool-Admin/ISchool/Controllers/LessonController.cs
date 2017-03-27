using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.DAL.Context;
using ISchool.Service.Services;

namespace ISchool.Controllers
{
    public class LessonController : BaseController
    {
        private Lazy<ILessonService> _lessonService;
        public LessonController(IDbContext context,ILessonService lessonService) : base(context)
        {
            _lessonService = new Lazy<ILessonService>(() => lessonService);
        }

        // GET: Lesson
        public ActionResult Index()
        {
            return View();
        }
    }
}