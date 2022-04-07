using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string RoomNo { get; set; }
        public string Title { get; set; }
        public int MaxAdults { get; set; }
        public int MaxChilds { get; set; }
        public decimal RoomFare { get; set; }
        public string Description { get; set; }
        public int NoOfBeds { get; set; }
        public string RoomPictureUri { get; set; }
        public RoomType TypeOfRoom { get; set; }
        public int RoomTypeId { get; set; }
        public ICollection<RoomFacility> Facilities { get; set; }=new List<RoomFacility>();
    }
}