namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wearRecovery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Material", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Material");
        }
    }
}
