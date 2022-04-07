using GeoAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        /* public ICloneable<RoomFacility> Facilities { get; set; } = new List<RoomFacility>();*//*
        public ICloneable<RoomFacility> Facilities { get; set; } = new List<RoomFacility>();*/
    }

   
}