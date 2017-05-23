namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AcceporTurnoverRecov : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turnovers", "AcceptorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Turnovers", "AcceptorId");
            AddForeignKey("dbo.Turnovers", "AcceptorId", "dbo.Acceptors", "AcceptorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnovers", "AcceptorId", "dbo.Acceptors");
            DropIndex("dbo.Turnovers", new[] { "AcceptorId" });
            DropColumn("dbo.Turnovers", "AcceptorId");
        }
    }
}
