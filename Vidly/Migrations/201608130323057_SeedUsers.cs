namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4a1c508c-342a-4664-8beb-cb586bd95463', N'guest@vidly.com', 0, N'ACh02qt4oGzJnUWUyp/YyoAfGuRwIv7bojGWK36aRGKEjwIML5R7+yMXPbqX/drJfg==', N'264df314-29cf-4752-8c53-0092366ed7d9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9775b333-9584-440d-827f-e7defb0544a9', N'admin@vidly.com', 0, N'AFhyBw6NDc6Dgql2mEZ/Bzo7VSTWx0rd2MHcbZbb1sdiz5FGwvpxnY4kwCjh3m3BHA==', N'ebc909ef-ac71-4031-b534-ef0bbc62b878', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0214ab90-7bae-427e-91df-3c9da2ffbcf0', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9775b333-9584-440d-827f-e7defb0544a9', N'0214ab90-7bae-427e-91df-3c9da2ffbcf0')

");
        }
        
        public override void Down()
        {
        }
    }
}
