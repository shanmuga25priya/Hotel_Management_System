namespace Hotel_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestId = c.Int(nullable: false, identity: true),
                        RoomNo = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Company = c.String(),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Gender = c.String(),
                        Address = c.String(nullable: false),
                        Subject = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.GuestId);
            
            CreateTable(
                "dbo.InventoryReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalIncome = c.Double(),
                        MaintainanceCost = c.Double(),
                        EmployeeSalary = c.Double(),
                        TotalProfit = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Issuebills",
                c => new
                    {
                        IssueBillId = c.Int(nullable: false, identity: true),
                        RoomNo = c.Int(),
                        BillNo = c.Int(),
                        Quantity = c.Int(),
                        Price = c.Double(),
                        Taxes = c.Double(),
                        Date = c.DateTime(),
                        Services = c.Double(),
                        Total = c.Double(),
                    })
                .PrimaryKey(t => t.IssueBillId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomNo = c.Int(nullable: false),
                        CreditCardDetails = c.String(nullable: false),
                        Total = c.Double(nullable: false),
                        PayTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        RoomNo = c.Int(nullable: false),
                        NumberOfChildren = c.Int(nullable: false),
                        NumberOfAdults = c.Int(nullable: false),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        NumberOfNights = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomNumber = c.Int(nullable: false),
                        RoomType = c.String(nullable: false),
                        IsOccupied = c.String(),
                        RoomCost = c.Long(nullable: false),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RoomNumber);
            
            CreateTable(
                "dbo.SetRates",
                c => new
                    {
                        SetRateId = c.Int(nullable: false, identity: true),
                        NumberOfGuests = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        OneNightPrice = c.Double(nullable: false),
                        Extention = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SetRateId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        EmployeeAddress = c.String(nullable: false),
                        Salary = c.Double(nullable: false),
                        Age = c.Int(nullable: false),
                        Occupation = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        WorkDomain = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        RePassword = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Staffs");
            DropTable("dbo.SetRates");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Payments");
            DropTable("dbo.Issuebills");
            DropTable("dbo.InventoryReports");
            DropTable("dbo.Guests");
        }
    }
}
