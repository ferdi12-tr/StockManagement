namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserId" });
            CreateTable(
                "dbo.UserOrders",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Order_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Order_Id);
            
            AddColumn("dbo.Products", "Order_Id", c => c.Int());
            AddColumn("dbo.Orders", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Order_Id");
            AddForeignKey("dbo.Products", "Order_Id", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.UserOrders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropIndex("dbo.UserOrders", new[] { "Order_Id" });
            DropIndex("dbo.UserOrders", new[] { "User_Id" });
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropColumn("dbo.Orders", "ProductId");
            DropColumn("dbo.Products", "Order_Id");
            DropTable("dbo.UserOrders");
            CreateIndex("dbo.Orders", "UserId");
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
