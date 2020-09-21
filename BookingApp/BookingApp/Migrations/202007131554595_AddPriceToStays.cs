namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPriceToStays : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stays", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stays", "Price");
        }
    }
}
