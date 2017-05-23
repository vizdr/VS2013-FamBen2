namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProdSubgroupRecov : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdSubGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "ProdSubGroupId", c => c.Int());
            CreateIndex("dbo.Products", "ProdSubGroupId");
            AddForeignKey("dbo.Products", "ProdSubGroupId", "dbo.ProdSubGroups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProdSubGroupId", "dbo.ProdSubGroups");
            DropIndex("dbo.Products", new[] { "ProdSubGroupId" });
            DropColumn("dbo.Products", "ProdSubGroupId");
            DropTable("dbo.ProdSubGroups");
        }
    }
}
