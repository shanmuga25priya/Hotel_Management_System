using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HotelBooking.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=conn")
        {
           
        }
        public DbSet<Facility> Facility { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomFacility> RoomFacility { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<SearchRoomViewModel> SearchRoomViewModel { get; set; }
       

    }
}