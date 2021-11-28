using MMS.Data.Models;
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

        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);

            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {

            if (ModelState.IsValid)
            {
                db.Add(member);
                TempData["Message"] = "You have successfully created a Member.";
                return RedirectToAction("Details", new { id = member.Id });
            }

            return View();

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Member member)
        {
            if (ModelState.IsValid)
            {
                db.Update(member);
                TempData["Message"] = "You have successfully edited the Member.";
                return RedirectToAction("Details", new { id = member.Id });
            }

            return View(member);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View("Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}