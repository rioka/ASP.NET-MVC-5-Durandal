﻿using System.Web.Mvc;

namespace WebApplication.Controllers.Home
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ViewResult Loading()
        {
            return View();
        }

        [AllowAnonymous]
        public ViewResult Shell()
        {
            return View();
        }

        [AllowAnonymous]
        public ViewResult Welcome()
        {
            return View();
        }

        public ViewResult Start()
        {
            return View();
        }

        public ViewResult Home()
        {
            return View();
        }

        public ViewResult Flickr()
        {
            return View();
        }

        public ViewResult Detail()
        {
            return View();
        }
    }
}
