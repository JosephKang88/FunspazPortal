using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FunspazPortal.Models;

namespace FunspazPortal.Controllers
{
    public class ListController : Controller
    {
        private digitaluxeEntities db = new digitaluxeEntities();
        // GET: Beauty
        public ActionResult Beauty()
        {
            var contents = db.contents.Include(c => c.service1);
            return View(contents.ToList());
        }

        // GET: Love
        public ActionResult Love()
        {
            return View();
        }

        // GET: Entreprenuer
        public ActionResult Entreprenuer()
        {
            return View();
        }

        // GET: Travel
        public ActionResult Travel()
        {
            return View();
        }

        // GET: Weather
        public ActionResult Weather()
        {
            return View();
        }

        // GET: Funny
        public ActionResult Funny()
        {
            return View();
        }
    }
}