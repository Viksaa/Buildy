namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUserComputers",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        Computer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.Computer_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.Computers", t => t.Computer_Id, cascadeDelete: true)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Computer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserComputers", "Computer_Id", "dbo.Computers");
            DropForeignKey("dbo.ApplicationUserComputers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserComputers", new[] { "Computer_Id" });
            DropIndex("dbo.ApplicationUserComputers", new[] { "ApplicationUser_Id" });
            DropTable("dbo.ApplicationUserComputers");
        }
    }
}
