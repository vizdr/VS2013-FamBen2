namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceRecov : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Periodicity", c => c.DateTime());
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Discriminator");
            DropColumn("dbo.Products", "Periodicity");
        }
    }
}
