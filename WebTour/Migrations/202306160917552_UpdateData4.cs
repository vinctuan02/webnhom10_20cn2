namespace WebTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Product1", "ProductCategoryId", "dbo.tb_ProductCategory");
            DropIndex("dbo.tb_Product1", new[] { "ProductCategoryId" });
            RenameColumn(table: "dbo.tb_Product1", name: "ProductCategoryId", newName: "ProductCategory_Id");
            AddColumn("dbo.tb_Product1", "CodeTour", c => c.String());
            AddColumn("dbo.tb_Product1", "TourCategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Product1", "ProductCategory_Id", c => c.Int());
            CreateIndex("dbo.tb_Product1", "ProductCategory_Id");
            AddForeignKey("dbo.tb_Product1", "ProductCategory_Id", "dbo.tb_ProductCategory", "Id");
            DropColumn("dbo.tb_Product1", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product1", "Country", c => c.String());
            DropForeignKey("dbo.tb_Product1", "ProductCategory_Id", "dbo.tb_ProductCategory");
            DropIndex("dbo.tb_Product1", new[] { "ProductCategory_Id" });
            AlterColumn("dbo.tb_Product1", "ProductCategory_Id", c => c.Int(nullable: false));
            DropColumn("dbo.tb_Product1", "TourCategoryId");
            DropColumn("dbo.tb_Product1", "CodeTour");
            RenameColumn(table: "dbo.tb_Product1", name: "ProductCategory_Id", newName: "ProductCategoryId");
            CreateIndex("dbo.tb_Product1", "ProductCategoryId");
            AddForeignKey("dbo.tb_Product1", "ProductCategoryId", "dbo.tb_ProductCategory", "Id", cascadeDelete: true);
        }
    }
}
