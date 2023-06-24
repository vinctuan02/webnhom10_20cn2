namespace WebTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Category", "SeoTitle");
            DropColumn("dbo.tb_Category", "SeoDescription");
            DropColumn("dbo.tb_Category", "SeoKeywords");
            DropColumn("dbo.tb_New1", "SeoTitle");
            DropColumn("dbo.tb_New1", "SeoDescription");
            DropColumn("dbo.tb_New1", "SeoKeywords");
            DropColumn("dbo.tb_Product1", "SeoTitle");
            DropColumn("dbo.tb_Product1", "SeoDescription");
            DropColumn("dbo.tb_Product1", "SeoKeywords");
            DropColumn("dbo.tb_ProductCategory", "SeoTitle");
            DropColumn("dbo.tb_ProductCategory", "SeoDescription");
            DropColumn("dbo.tb_ProductCategory", "SeoKeywords");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Product1", "SeoKeywords", c => c.String());
            AddColumn("dbo.tb_Product1", "SeoDescription", c => c.String());
            AddColumn("dbo.tb_Product1", "SeoTitle", c => c.String());
            AddColumn("dbo.tb_New1", "SeoKeywords", c => c.String());
            AddColumn("dbo.tb_New1", "SeoDescription", c => c.String());
            AddColumn("dbo.tb_New1", "SeoTitle", c => c.String());
            AddColumn("dbo.tb_Category", "SeoKeywords", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Category", "SeoDescription", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Category", "SeoTitle", c => c.String(maxLength: 250));
        }
    }
}
