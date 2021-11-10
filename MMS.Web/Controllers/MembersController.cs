using MMS.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MMS.Web.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMemberService db;

        public MembersController(IMemberService db)
        {
            this.db = db;
        }
        // GET: Members
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);

            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}