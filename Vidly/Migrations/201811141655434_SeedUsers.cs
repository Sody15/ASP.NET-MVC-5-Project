namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'24574548-7851-4cbb-8356-c40af3682109', N'guest@vidly.com', 0, N'AENyvEYr8bHKJiux6iHnOO09+QGoaR1Yp2rEmz1FlfeVtB51/D8UXPMLZDcQosei9Q==', N'f6b54690-e8de-4438-9bb1-330fd1aa786d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");

            Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'5686829e-50a8-4244-953c-0ccb3af864e5', N'admin1@vidly.com', 0, N'ADms8eAL5WuUHx108kwUiZmZVyCMBYml/3oLfpZesyFEwYqu6AjUFe3N3IeDh+LPkQ==', N'162aa093-c738-4301-a202-80c57a5cedf7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");

            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'17b7dfae-b9e1-4a7b-99db-6d3a6045d930', N'CanManageMovies')");

            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5686829e-50a8-4244-953c-0ccb3af864e5', N'17b7dfae-b9e1-4a7b-99db-6d3a6045d930')");

        }

        public override void Down()
        {
        }
    }
}
