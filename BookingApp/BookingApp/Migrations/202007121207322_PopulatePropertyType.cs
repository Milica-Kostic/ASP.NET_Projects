namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePropertyType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Hotels')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Apartments')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Resort')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Villas')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Cabins')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Cottages')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Glamping')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Serviced Apartments')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Vacation Homes')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Guest Houses')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Hostels')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Motels')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Raids')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Resort Villages')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Homestays')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Farm Stays')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Boats')");
            Sql("INSERT INTO PropertyTypes (TypeName) VALUES ('Campgrounds')");
        }
        
        public override void Down()
        {
        }
    }
}
