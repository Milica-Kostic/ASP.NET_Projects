namespace BookingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Name], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) " +
                "VALUES (N'cf52f553-5e8c-4144-acf8-fbaad7090f10', N'Milica', N'Kostic', N'guest@g.com', 0, N'ANcJAEesqM3si47iYSIcA3Av0Ykj/e2hGXEx/ggiu4zhNO75AoLCWqFBPN9k9pJKQg==', N'79d82714-e2e5-4e65-8f3b-f39cfd6a0afd', NULL, 0, 0, NULL, 1, 0, N'guest@g.com')" +
                "INSERT INTO[dbo].[AspNetUsers]([Id], [Name], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) " +
                "VALUES(N'cf5a5ab0-1f58-419a-8631-bf0d02509c4f', N'Milica', N'Kostic', N'admin@admin.com', 0, N'ANhUpudUiRrBcS5n7vrYYESQDj+nxr0FBKKw6u5WMIrtf8zgcUgY+e8p4SprZauxUg==', N'4129d1c2-a090-4d64-bf66-cc259a130ced', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')");

            Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) 
                VALUES (N'7fb28377-7d62-46db-a0dd-70a37d3bc768', N'Admin')
                ");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) 
                VALUES (N'cf5a5ab0-1f58-419a-8631-bf0d02509c4f', N'7fb28377-7d62-46db-a0dd-70a37d3bc768')
               ");
        }
        
        public override void Down()
        {
        }
    }
}
