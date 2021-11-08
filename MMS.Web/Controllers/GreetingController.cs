﻿using MMS.Web.Models;
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
        public ActionResult Index(string name)
        {
            var viewModel = new GreetingViewModel();
            viewModel.Name = name ?? "No Name";
            viewModel.Message = ConfigurationManager.AppSettings["message"];
            return View(viewModel);
        }
    }
}