using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BettingApplication.Models;

namespace BettingApplication.Controllers
{
    public class UserDbTests1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserDbTests1
        public ActionResult Index()
        {
            return View(db.UserDbTests.ToList());
        }

        // GET: UserDbTests1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDbTest userDbTest = db.UserDbTests.Find(id);
            if (userDbTest == null)
            {
                return HttpNotFound();
            }
            return View(userDbTest);
        }

        // GET: UserDbTests1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserDbTests1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age")] UserDbTest userDbTest)
        {
            if (ModelState.IsValid)
            {
                db.UserDbTests.Add(userDbTest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userDbTest);
        }

        // GET: UserDbTests1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDbTest userDbTest = db.UserDbTests.Find(id);
            if (userDbTest == null)
            {
                return HttpNotFound();
            }
            return View(userDbTest);
        }

        // POST: UserDbTests1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age")] UserDbTest userDbTest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userDbTest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userDbTest);
        }

        // GET: UserDbTests1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDbTest userDbTest = db.UserDbTests.Find(id);
            if (userDbTest == null)
            {
                return HttpNotFound();
            }
            return View(userDbTest);
        }

        // POST: UserDbTests1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserDbTest userDbTest = db.UserDbTests.Find(id);
            db.UserDbTests.Remove(userDbTest);
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
