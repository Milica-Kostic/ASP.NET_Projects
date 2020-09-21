namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullDescription : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Stays", "Description", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stays", "Description", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
