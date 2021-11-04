using MMS.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MMS.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            var viewModel = new GreetingViewModel();
            viewModel.Message = ConfigurationManager.AppSettings["message"];
            return View(viewModel);
        }
    }
}