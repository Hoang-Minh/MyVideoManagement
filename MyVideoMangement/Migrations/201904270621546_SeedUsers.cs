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
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a720e705-e77e-4669-9364-0b109f9f3cff', N'admin@vidly.com', 0, N'AGYdYW9jVeRzcxodbGhyHRCbX9FIwtYx9aOrUDiGHr7EHqf7PXJfIAg6d8wRkDk+cw==', N'8677e280-5117-4230-b4eb-e91c5b32f3cf', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b087e219-e40f-4b05-a088-ff1e9f464883', N'CanManageMovies')
");
        }
        
        public override void Down()
        {
        }
    }
}
