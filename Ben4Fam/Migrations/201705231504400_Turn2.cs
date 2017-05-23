namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Turn2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Turnovers", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Suppliers", "SupplierId", "dbo.People");
            DropIndex("dbo.Turnovers", new[] { "ProductId" });
            DropIndex("dbo.Suppliers", new[] { "SupplierId" });
            DropColumn("dbo.Turnovers", "ProductId");
            DropTable("dbo.Suppliers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            AddColumn("dbo.Turnovers", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Suppliers", "SupplierId");
            CreateIndex("dbo.Turnovers", "ProductId");
            AddForeignKey("dbo.Suppliers", "SupplierId", "dbo.People", "Id");
            AddForeignKey("dbo.Turnovers", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
