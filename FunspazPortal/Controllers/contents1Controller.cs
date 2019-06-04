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
    public class contents1Controller : Controller
    {
        private digitaluxeEntities db = new digitaluxeEntities();

        // GET: contents1
        public ActionResult Index()
        {
            var contents = db.contents.Include(c => c.service1);
            return View(contents.ToList());
        }

        // GET: contents1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            content content = db.contents.Find(id);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // GET: contents1/Create
        public ActionResult Create()
        {
            ViewBag.service = new SelectList(db.services, "id", "servicename");
            return View();
        }

        // POST: contents1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,service,title,icon,image1,image2,insertdate,remark")] content content)
        {
            if (ModelState.IsValid)
            {
                db.contents.Add(content);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.service = new SelectList(db.services, "id", "servicename", content.service);
            return View(content);
        }

        // GET: contents1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            content content = db.contents.Find(id);
            if (content == null)
            {
                return HttpNotFound();
            }
            ViewBag.service = new SelectList(db.services, "id", "servicename", content.service);
            return View(content);
        }

        // POST: contents1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,service,title,icon,image1,image2,insertdate,remark")] content content)
        {
            if (ModelState.IsValid)
            {
                db.Entry(content).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.service = new SelectList(db.services, "id", "servicename", content.service);
            return View(content);
        }

        // GET: contents1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            content content = db.contents.Find(id);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: contents1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            content content = db.contents.Find(id);
            db.contents.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
