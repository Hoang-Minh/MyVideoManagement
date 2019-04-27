namespace MyVideoMangement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'84bef181-419b-4638-921c-853b5c3dab4d', N'guest@vidly.com', 0, N'AD9P6jQTSH9BjM6ngX1/8eolTK0be9isnaoVYa4NIRp3Lxhcc26/0US+4ny+g1BZSw==', N'400271d5-1f63-4c25-a28a-da269d5f0818', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e63df73c-dabe-4c20-9252-0b2d414b88f8', N'admin@vidly.com', 0, N'ALX7s4ln9VlH2WbtKYFSnKiHAaoojYtxo+tJLATTS04brwT2+q7594DqubOzp/G0pg==', N'2664f37b-ebbe-48c6-ae4e-b7234bb196cb', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b087e219-e40f-4b05-a088-ff1e9f464883', N'CanManageMovies')
");
        }
        
        public override void Down()
        {
        }
    }
}
