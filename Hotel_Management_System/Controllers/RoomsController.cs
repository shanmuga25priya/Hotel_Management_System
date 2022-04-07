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
    public class RoomsController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: SearchRooms---------------------------------------------------------

        public ActionResult Index(string searchString)
        {
            var Room = from m in db.Rooms
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                Room = Room.Where(s => s.IsOccupied.Contains(searchString));
                return View(Room);
            }

            return View(db.Rooms.ToList());
        }



        // GET: SearchRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rooms searchRooms = db.Rooms.Find(id);
            if (searchRooms == null)
            {
                return HttpNotFound();
            }
            return View(searchRooms);
        }


        // GET: SearchRooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SearchRooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoomNumber,RoomType,IsOccupied,RoomCost,CheckIn,CheckOut")] Rooms searchRooms)
        {

            if (searchRooms.RoomNumber != 0)
            {
                try
                {
                    Rooms roomInfo = db.Rooms.Where(x => x.RoomNumber == searchRooms.RoomNumber).First();
                    if (roomInfo != null)
                    {
                        ViewBag.ErrorMsg = $"Error : Room number {searchRooms.RoomNumber} already exists. Please enter a new Room Number.";
                        return View(searchRooms);
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMsg = $"Room number is safe to use.";
                }
            }

            if (ModelState.IsValid)
            {
                if (searchRooms.RoomNumber == 0)
                {
                    ViewBag.ErrorMsg = $"Error : Please enter room number other than 0.";
                    return View(searchRooms);
                }
                db.Rooms.Add(searchRooms);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(searchRooms);
        }


        // GET: SearchRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rooms searchRooms = db.Rooms.Find(id);
            if (searchRooms == null)
            {
                return HttpNotFound();
            }
            return View(searchRooms);
        }


        // POST: SearchRooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoomNumber,RoomType,IsOccupied,RoomCost,CheckIn,CheckOut")] Rooms searchRooms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(searchRooms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(searchRooms);
        }


        // GET: SearchRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rooms searchRooms = db.Rooms.Find(id);
            if (searchRooms == null)
            {
                return HttpNotFound();
            }
            return View(searchRooms);
        }


        // POST: SearchRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rooms searchRooms = db.Rooms.Find(id);
            db.Rooms.Remove(searchRooms);
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
