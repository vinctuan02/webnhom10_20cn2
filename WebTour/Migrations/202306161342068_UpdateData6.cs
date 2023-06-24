namespace WebTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Product1", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Product1", "PriceSale", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Product1", "PriceSale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tb_Product1", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
