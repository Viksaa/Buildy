namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Computer_usertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComputerId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Computers", t => t.ComputerId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.ComputerId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Computers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.User_Computers", "ComputerId", "dbo.Computers");
            DropIndex("dbo.User_Computers", new[] { "UserId" });
            DropIndex("dbo.User_Computers", new[] { "ComputerId" });
            DropTable("dbo.User_Computers");
        }
    }
}
