namespace Ben4Fam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Acceptors", "AcceptorId", "dbo.People");
            DropIndex("dbo.Acceptors", new[] { "AcceptorId" });
            DropTable("dbo.Acceptors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Acceptors",
                c => new
                    {
                        AcceptorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AcceptorId);
            
            CreateIndex("dbo.Acceptors", "AcceptorId");
            AddForeignKey("dbo.Acceptors", "AcceptorId", "dbo.People", "Id");
        }
    }
}
