namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAnnotationsForPropType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "CityName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Countries", "CountryName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PropertyTypes", "TypeName", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PropertyTypes", "TypeName", c => c.String());
            AlterColumn("dbo.Countries", "CountryName", c => c.String(nullable: false));
            AlterColumn("dbo.Cities", "CityName", c => c.String(nullable: false));
        }
    }
}
