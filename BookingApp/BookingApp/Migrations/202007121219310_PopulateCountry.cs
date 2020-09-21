namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCountry : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Countries (CountryName) VALUES ('France') ");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Italy') ");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Spain') ");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Germany') ");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Greece') ");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Poland')");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Serbia')");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Portugal')");
            Sql("INSERT INTO Countries (CountryName) VALUES ('USA') ");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Russia')");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Brazil')");
            Sql("INSERT INTO Countries (CountryName) VALUES ('India')");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Japan')");
            Sql("INSERT INTO Countries (CountryName) VALUES ('Australia')"); 
            Sql("INSERT INTO Countries (CountryName) VALUES ('Mexico')"); 
        }
        
        public override void Down()
        {
        }
    }
}
