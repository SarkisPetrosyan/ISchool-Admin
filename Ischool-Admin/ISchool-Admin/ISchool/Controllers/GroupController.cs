using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.DAL.Context;
using ISchool.Service.Services;

namespace ISchool.Controllers
{
    public class GroupController : BaseController
    {
        private Lazy<IGroupService> _groupService;
        public GroupController(IDbContext context, IGroupService groupService) : base(context)
        {
            _groupService = new Lazy<IGroupService>(() => groupService);
        }

        // GET: Group
        public ActionResult Index()
        {
            return View();
        }
    }
}