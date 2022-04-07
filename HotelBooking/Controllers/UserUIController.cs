using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelBooking.Controllers
{
    public class UserUIController : Controller
    {
        // GET: UserUI
        public ActionResult Index()
        {
            return View();
        }

        /*[HttpGet]
        public ActionResult SearchResult(SearchRoomViewModel vm)
        {

        }*/
    }
}