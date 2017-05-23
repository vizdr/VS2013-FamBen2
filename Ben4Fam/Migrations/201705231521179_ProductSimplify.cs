namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductSimplify : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ProdGroupId", "dbo.ProdGroups");
            DropForeignKey("dbo.Products", "ProdSubGroupId", "dbo.ProdSubGroups");
            DropIndex("dbo.Products", new[] { "ProdGroupId" });
            DropIndex("dbo.Products", new[] { "ProdSubGroupId" });
            DropColumn("dbo.Products", "ProdGroupId");
            DropColumn("dbo.Products", "Periodicity");
            DropColumn("dbo.Products", "LifeTime");
            DropColumn("dbo.Products", "GarantieTime");
            DropColumn("dbo.Products", "Material");
            DropColumn("dbo.Products", "ProdSubGroupId");
            DropColumn("dbo.Products", "Discriminator");
            DropTable("dbo.ProdGroups");
            DropTable("dbo.ProdSubGroups");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProdSubGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProdGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Products", "ProdSubGroupId", c => c.Int());
            AddColumn("dbo.Products", "Material", c => c.String());
            AddColumn("dbo.Products", "GarantieTime", c => c.DateTime());
            AddColumn("dbo.Products", "LifeTime", c => c.DateTime());
            AddColumn("dbo.Products", "Periodicity", c => c.DateTime());
            AddColumn("dbo.Products", "ProdGroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ProdSubGroupId");
            CreateIndex("dbo.Products", "ProdGroupId");
            AddForeignKey("dbo.Products", "ProdSubGroupId", "dbo.ProdSubGroups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ProdGroupId", "dbo.ProdGroups", "Id", cascadeDelete: true);
        }
    }
}
