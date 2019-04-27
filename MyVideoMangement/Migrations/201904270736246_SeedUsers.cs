namespace MyVideoMangement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3bd695bc-b0d0-4fb5-9d96-aad60e00e27d', N'admin@vidly.com', 0, N'AMCJfApa5R02wTGuw8RhyhQ+MNrc2gXw4t4nyjVPMNgNWjZzgW672rLjJgPBkZC67A==', N'988571c1-b188-4bb7-bef0-7b1f719dafa2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7bf0e285-fe48-4ef1-94e7-da8bd8eb7fc9', N'guest@vidly.com', 0, N'AJwqQPGw77j1bOLJbmy+Kcd1aVq9GnCyvS/lALZpm/M25giWVCYCVCPsTwpuGnjhcA==', N'0b82a2bd-89df-416f-93c2-8a694e08a7e4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e94622ac-1ab6-4288-906c-8db1cb9ce2de', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3bd695bc-b0d0-4fb5-9d96-aad60e00e27d', N'e94622ac-1ab6-4288-906c-8db1cb9ce2de')

");
        }
        
        public override void Down()
        {
        }
    }
}
