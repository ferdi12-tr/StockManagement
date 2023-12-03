namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrderAndSell : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.SellProducts", "Quantity");
            DropColumn("dbo.SellProducts", "Price");
            DropColumn("dbo.SellProducts", "TotalPrice");
            DropColumn("dbo.Orders", "OrderDateTine");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderDateTine", c => c.DateTime(nullable: false));
            AddColumn("dbo.SellProducts", "TotalPrice", c => c.Double(nullable: false));
            AddColumn("dbo.SellProducts", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.SellProducts", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Quantity");
            DropColumn("dbo.Orders", "OrderDateTime");
        }
    }
}
