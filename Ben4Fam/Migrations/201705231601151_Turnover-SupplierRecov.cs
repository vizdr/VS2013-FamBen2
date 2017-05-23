namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TurnoverSupplierRecov : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turnovers", "SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.Turnovers", "SupplierId");
            AddForeignKey("dbo.Turnovers", "SupplierId", "dbo.Suppliers", "SupplierId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnovers", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Turnovers", new[] { "SupplierId" });
            DropColumn("dbo.Turnovers", "SupplierId");
        }
    }
}
