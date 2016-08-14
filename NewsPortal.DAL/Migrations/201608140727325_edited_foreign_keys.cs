namespace NewsPortal.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edited_foreign_keys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Id", "dbo.Roles");
            DropForeignKey("dbo.News", "Id", "dbo.Users");
            DropIndex("dbo.Comments", new[] { "Id" });
            DropIndex("dbo.Users", new[] { "Id" });
            DropIndex("dbo.News", new[] { "Id" });
            AddColumn("dbo.Comments", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Users", "RoleId", c => c.Guid(nullable: false));
            AddColumn("dbo.News", "UserId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Comments", "UserId");
            CreateIndex("dbo.Users", "RoleId");
            CreateIndex("dbo.News", "UserId");
            AddForeignKey("dbo.Comments", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.News", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropIndex("dbo.News", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropColumn("dbo.News", "UserId");
            DropColumn("dbo.Users", "RoleId");
            DropColumn("dbo.Comments", "UserId");
            CreateIndex("dbo.News", "Id");
            CreateIndex("dbo.Users", "Id");
            CreateIndex("dbo.Comments", "Id");
            AddForeignKey("dbo.News", "Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.Comments", "Id", "dbo.Users", "Id");
        }
    }
}
