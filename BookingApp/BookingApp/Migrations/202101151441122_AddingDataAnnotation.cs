namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "CityName", c => c.String(nullable: false));
            AlterColumn("dbo.Countries", "CountryName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "CountryName", c => c.String());
            AlterColumn("dbo.Cities", "CityName", c => c.String());
        }
    }
}
