namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConstraint : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Stays ADD CONSTRAINT [FK_dbo.Stays_dbo.Cities_CityId] FOREIGN KEY (CityId) REFERENCES Cities(Id) ON DELETE CASCADE");
        }
        
        public override void Down()
        {
        }
    }
}
