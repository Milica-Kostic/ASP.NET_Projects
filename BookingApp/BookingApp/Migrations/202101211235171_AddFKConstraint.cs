namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKConstraint : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Stays ADD CONSTRAINT [FK_dbo.Stays_dbo.Cities_CityId] FOREIGN KEY (CityId) REFERENCES Cities(Id)");
        }
        
        public override void Down()
        {
        }
    }
}
