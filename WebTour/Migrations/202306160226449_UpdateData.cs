namespace WebTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Alias", c => c.String());
            AddColumn("dbo.tb_New1", "Alias", c => c.String());
            AddColumn("dbo.tb_Product1", "Alias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product1", "Alias");
            DropColumn("dbo.tb_New1", "Alias");
            DropColumn("dbo.tb_Category", "Alias");
        }
    }
}
