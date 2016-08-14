namespace NewsPortal.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_news_link_to_comment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "NewsId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Comments", "NewsId");
            AddForeignKey("dbo.Comments", "NewsId", "dbo.News", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "NewsId", "dbo.News");
            DropIndex("dbo.Comments", new[] { "NewsId" });
            DropColumn("dbo.Comments", "NewsId");
        }
    }
}
