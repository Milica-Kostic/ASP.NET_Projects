namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCities : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cities (CityName) VALUES ('Paris')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Marseille')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Rome')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Venice')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Madrid')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Barselona')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Berlin')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Munich')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Volos')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Athens')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Warsaw')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Zakopane')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Belgrade')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Nis')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Tokyo')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Saporo')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Lisbon')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Porto')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Miami')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Los Angeles')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Saint Petersburg')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Sochi')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Sao Paulo')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Brasilia')");
            Sql("INSERT INTO Cities (CityName) VALUES ('New Delhi')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Mumbai')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Sydney')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Melburne')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Acapulco')");
            Sql("INSERT INTO Cities (CityName) VALUES ('Tulum')");
        }
        
        public override void Down()
        {
        }
    }
}
