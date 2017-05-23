namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductTurnoverRecovery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turnovers", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Turnovers", "ProductId");
            AddForeignKey("dbo.Turnovers", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnovers", "ProductId", "dbo.Products");
            DropIndex("dbo.Turnovers", new[] { "ProductId" });
            DropColumn("dbo.Turnovers", "ProductId");
        }
    }
}
