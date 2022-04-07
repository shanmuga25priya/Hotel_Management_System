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
    public class InventoryReportsController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: InventoryReports
        public ActionResult Index()
        {
            return View(db.InventoryReports.ToList());
        }

        //Callculate
        public ActionResult calculate()
        {
            return View(new InventoryReports());
        }
        
        [HttpPost]
        public ActionResult calculate(InventoryReports i, string calculate)
        {
            i.TotalProfit = i.TotalIncome - (i.MaintainanceCost + i.EmployeeSalary);

            db.InventoryReports.Add(i);
            db.SaveChanges();
            return View(i);
        }

        // GET: InventoryReports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryReports inventoryReports = db.InventoryReports.Find(id);
            if (inventoryReports == null)
            {
                return HttpNotFound();
            }
            return View(inventoryReports);
        }

        // GET: InventoryReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventoryReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TotalIncome,TotalExpenditure,MaintainanceCost,EmployeeSalary")] InventoryReports inventoryReports)
        {
            if (ModelState.IsValid)
            {
                db.InventoryReports.Add(inventoryReports);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inventoryReports);
        }

        // GET: InventoryReports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryReports inventoryReports = db.InventoryReports.Find(id);
            if (inventoryReports == null)
            {
                return HttpNotFound();
            }
            return View(inventoryReports);
        }

        // POST: InventoryReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TotalIncome,TotalExpenditure,MaintainanceCost,EmployeeSalary")] InventoryReports inventoryReports)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventoryReports).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inventoryReports);
        }

        // GET: InventoryReports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryReports inventoryReports = db.InventoryReports.Find(id);
            if (inventoryReports == null)
            {
                return HttpNotFound();
            }
            return View(inventoryReports);
        }

        // POST: InventoryReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InventoryReports inventoryReports = db.InventoryReports.Find(id);
            db.InventoryReports.Remove(inventoryReports);
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
