﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Project_EatSmart.Controllers
{
    [Authorize]
    public class DiaryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}