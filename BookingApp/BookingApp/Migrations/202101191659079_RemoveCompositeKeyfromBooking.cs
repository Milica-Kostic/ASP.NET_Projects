namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCompositeKeyfromBooking : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bookings");
            AddColumn("dbo.Bookings", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bookings", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bookings");
            DropColumn("dbo.Bookings", "Id");
            AddPrimaryKey("dbo.Bookings", new[] { "ConsumerId", "StayId" });
        }
    }
}
