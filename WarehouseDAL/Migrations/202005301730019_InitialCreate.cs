namespace WarehouseDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(),
                        Title = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        ProductGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.ProductGroups", t => t.ProductGroupId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.ProductGroupId);
            
            CreateTable(
                "dbo.ProductDeliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        DeliveryId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deliveries", t => t.DeliveryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.DeliveryId);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProviderId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        DeliveryDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.ProviderId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        DateBorn = c.DateTime(),
                        ContactPerson = c.String(),
                        Position = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        DeliveryDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        IsCanOrder = c.Boolean(nullable: false),
                        OrganizationName = c.String(),
                        Address = c.String(),
                        ResponsiblePerson = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductShipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        DeliveryId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Shipment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Shipments", t => t.Shipment_Id)
                .Index(t => t.ProductId)
                .Index(t => t.Shipment_Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        OrganizationName = c.String(),
                        Address = c.String(),
                        ResponsiblePerson = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descriprion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductGroupId", "dbo.ProductGroups");
            DropForeignKey("dbo.ProductDeliveries", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Deliveries", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.ProductDeliveries", "DeliveryId", "dbo.Deliveries");
            DropForeignKey("dbo.ProductShipments", "Shipment_Id", "dbo.Shipments");
            DropForeignKey("dbo.ProductShipments", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Shipments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Shipments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Deliveries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Products", "CountryId", "dbo.Countries");
            DropIndex("dbo.ProductShipments", new[] { "Shipment_Id" });
            DropIndex("dbo.ProductShipments", new[] { "ProductId" });
            DropIndex("dbo.Shipments", new[] { "EmployeeId" });
            DropIndex("dbo.Shipments", new[] { "CustomerId" });
            DropIndex("dbo.Deliveries", new[] { "EmployeeId" });
            DropIndex("dbo.Deliveries", new[] { "ProviderId" });
            DropIndex("dbo.ProductDeliveries", new[] { "DeliveryId" });
            DropIndex("dbo.ProductDeliveries", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProductGroupId" });
            DropIndex("dbo.Products", new[] { "CountryId" });
            DropTable("dbo.ProductGroups");
            DropTable("dbo.Providers");
            DropTable("dbo.ProductShipments");
            DropTable("dbo.Customers");
            DropTable("dbo.Shipments");
            DropTable("dbo.Employees");
            DropTable("dbo.Deliveries");
            DropTable("dbo.ProductDeliveries");
            DropTable("dbo.Products");
            DropTable("dbo.Countries");
        }
    }
}
