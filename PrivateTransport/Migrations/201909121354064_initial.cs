namespace PrivateTransport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        startDest = c.String(nullable: false),
                        endDest = c.String(nullable: false),
                        UserID = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                        freeSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Routes");
        }
    }
}
