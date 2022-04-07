using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Hotel_Management_System.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(): base("name=conn")
        {

        }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Issuebill> Issuebill { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<SetRates> SetRates { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<InventoryReports> InventoryReports { get; set; }


    }
}

