namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThingRecover : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "LifeTime", c => c.DateTime());
            AddColumn("dbo.Products", "GarantieTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "GarantieTime");
            DropColumn("dbo.Products", "LifeTime");
        }
    }
}
