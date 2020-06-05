namespace WarehouseDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductShipments", "TottalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProductShipments", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.ProductShipments", "TotalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductShipments", "TotalPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.ProductShipments", "UnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.ProductShipments", "TottalPrice");
        }
    }
}
