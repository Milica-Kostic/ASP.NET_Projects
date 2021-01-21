namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropConstraint : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Stays DROP CONSTRAINT [FK_dbo.Stays_dbo.Cities_CityId]");
        }
        
        public override void Down()
        {
        }
    }
}
