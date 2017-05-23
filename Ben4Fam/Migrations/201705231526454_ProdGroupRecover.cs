namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProdGroupRecover : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "ProdGroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ProdGroupId");
            AddForeignKey("dbo.Products", "ProdGroupId", "dbo.ProdGroups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProdGroupId", "dbo.ProdGroups");
            DropIndex("dbo.Products", new[] { "ProdGroupId" });
            DropColumn("dbo.Products", "ProdGroupId");
            DropTable("dbo.ProdGroups");
        }
    }
}
