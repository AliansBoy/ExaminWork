namespace WarehouseDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            AddColumn("dbo.Employees", "FirstName", c => c.String());
            AddColumn("dbo.Employees", "SecondName", c => c.String());
            DropColumn("dbo.Employees", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Position", c => c.String());
            DropColumn("dbo.Employees", "SecondName");
            DropColumn("dbo.Employees", "FirstName");
            DropColumn("dbo.Products", "Image");
        }
    }
}
