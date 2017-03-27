using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.DAL.Context;

namespace ISchool.Controllers
{
    public class GroupController : BaseController
    {
        public GroupController(IDbContext context) : base(context)
        {
        }

        // GET: Group
        public ActionResult Index()
        {
            return View();
        }
    }
}