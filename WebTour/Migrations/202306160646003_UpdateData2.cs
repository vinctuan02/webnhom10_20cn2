namespace WebTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_ProductCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(nullable: false, maxLength: 150),
                        Description = c.String(),
                        Icon = c.String(maxLength: 250),
                        SeoTitle = c.String(maxLength: 250),
                        SeoDescription = c.String(maxLength: 500),
                        SeoKeywords = c.String(maxLength: 250),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifierDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tb_Product1", "ProductCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Product1", "ProductCategoryId");
            AddForeignKey("dbo.tb_Product1", "ProductCategoryId", "dbo.tb_ProductCategory", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Product1", "ProductCategoryId", "dbo.tb_ProductCategory");
            DropIndex("dbo.tb_Product1", new[] { "ProductCategoryId" });
            DropColumn("dbo.tb_Product1", "ProductCategoryId");
            DropTable("dbo.tb_ProductCategory");
        }
    }
}
