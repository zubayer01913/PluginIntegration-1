namespace PluginIntegration_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalesOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sr = c.Int(nullable: false),
                        OrderTrackNumber = c.String(),
                        Quantity = c.Int(nullable: false),
                        ProductName = c.String(),
                        SpecialOffer = c.String(),
                        UnitPrice = c.Double(nullable: false),
                        UnitPriceDiscount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SalesOrderDetails");
        }
    }
}
