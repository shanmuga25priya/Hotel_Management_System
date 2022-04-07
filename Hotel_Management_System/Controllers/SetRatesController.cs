using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_Management_System.Models;

namespace Hotel_Management_System.Controllers
{
    public class SetRatesController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: SetRates
        public ActionResult Index()
        {
            return View(db.SetRates.ToList());
        }

        // GET: SetRates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SetRates setRates = db.SetRates.Find(id);
            if (setRates == null)
            {
                return HttpNotFound();
            }
            return View(setRates);
        }

        // GET: SetRates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SetRates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SetRateId,NumberOfGuests,Day,OneNightPrice,Extention")] SetRates setRates)
        {
            if (ModelState.IsValid)
            {
                db.SetRates.Add(setRates);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(setRates);
        }

        // GET: SetRates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SetRates setRates = db.SetRates.Find(id);
            if (setRates == null)
            {
                return HttpNotFound();
            }
            return View(setRates);
        }

        // POST: SetRates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SetRateId,NumberOfGuests,Day,OneNightPrice,Extention")] SetRates setRates)
        {
            if (ModelState.IsValid)
            {
                db.Entry(setRates).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(setRates);
        }

        // GET: SetRates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SetRates setRates = db.SetRates.Find(id);
            if (setRates == null)
            {
                return HttpNotFound();
            }
            return View(setRates);
        }

        // POST: SetRates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SetRates setRates = db.SetRates.Find(id);
            db.SetRates.Remove(setRates);
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
