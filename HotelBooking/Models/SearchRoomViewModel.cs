using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class SearchRoomViewModel
    {
        public DateTime? DateFrom { get; set; } = null;
        public DateTime? DateTo { get; set; } = null;
        public int NoOfAdults { get; set; }
        public int NoOfChilds { get; set; }
        public IList<Room> Room { get; set; } = new List<Room>();

    }
}