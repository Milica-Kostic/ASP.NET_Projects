namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateConsumerAnnotation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Consumers", "LastName", c => c.String());
            AlterColumn("dbo.Consumers", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Stays", "Address", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stays", "Address", c => c.String());
            AlterColumn("dbo.Consumers", "Phone", c => c.String());
            DropColumn("dbo.Consumers", "LastName");
        }
    }
}
