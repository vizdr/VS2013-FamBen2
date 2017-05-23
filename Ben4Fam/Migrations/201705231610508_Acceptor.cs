namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Acceptor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acceptors",
                c => new
                    {
                        AcceptorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AcceptorId)
                .ForeignKey("dbo.People", t => t.AcceptorId)
                .Index(t => t.AcceptorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Acceptors", "AcceptorId", "dbo.People");
            DropIndex("dbo.Acceptors", new[] { "AcceptorId" });
            DropTable("dbo.Acceptors");
        }
    }
}
