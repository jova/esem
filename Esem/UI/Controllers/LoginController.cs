﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult loginpage()
        {
            return View();
        }
    }
}