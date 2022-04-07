using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_Management_System.Models;
using Rotativa;

namespace Hotel_Management_System.Controllers
{
    public class IssuebillsController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Issuebills
        public ActionResult Index()
        {
            return View(db.Issuebill.ToList());
        }

        //print docs

        public ActionResult GetAll()
        {
            var allprint=db.Issuebill.ToList();
            return View(allprint);
        }
        public ActionResult PrintAll()
        {
            var q = new ActionAsPdf("GetAll");
            return q;
        }



        public ActionResult addbill()
        {
            return View(new Issuebill());
        }
        //isuue bill
        [HttpPost]
        public ActionResult addbill(Issuebill i, string calculate)
        {
                i.Taxes = 0.18;
                i.Total = ((i.Price * i.Quantity)+i.Services)+i.Taxes;
               
                db.Issuebill.Add(i);
                db.SaveChanges();
            return View(i);

        }

        // GET: Issuebills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issuebill issuebill = db.Issuebill.Find(id);
            if (issuebill == null)
            {
                return HttpNotFound();
            }
            return View(issuebill);
        }

        // GET: Issuebills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Issuebills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IssueBillId,RoomNo,BillNo,Quantity,Price,Taxes,Date,Services,Total")] Issuebill issuebill)
        {
            if (ModelState.IsValid)
            {
                db.Issuebill.Add(issuebill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(issuebill);
        }

        // GET: Issuebills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issuebill issuebill = db.Issuebill.Find(id);
            if (issuebill == null)
            {
                return HttpNotFound();
            }
            return View(issuebill);
        }

        // POST: Issuebills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IssueBillId,RoomNo,BillNo,Quantity,Price,Taxes,Date,Services,Total")] Issuebill issuebill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(issuebill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issuebill);
        }

        // GET: Issuebills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issuebill issuebill = db.Issuebill.Find(id);
            if (issuebill == null)
            {
                return HttpNotFound();
            }
            return View(issuebill);
        }

        // POST: Issuebills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Issuebill issuebill = db.Issuebill.Find(id);
            db.Issuebill.Remove(issuebill);
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
