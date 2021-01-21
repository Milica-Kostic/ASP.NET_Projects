namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountryFKtoCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stays", "CountryId", "dbo.Countries");
            DropIndex("dbo.Stays", new[] { "CountryId" });
            AddColumn("dbo.Cities", "CountryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "CountryId");
            AddForeignKey("dbo.Cities", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
            DropColumn("dbo.Stays", "CountryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stays", "CountryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropColumn("dbo.Cities", "CountryId");
            CreateIndex("dbo.Stays", "CountryId");
            AddForeignKey("dbo.Stays", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}
