namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cpurefactor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CPUs", "SocketId", "dbo.Sockets");
            DropIndex("dbo.CPUs", new[] { "SocketId" });
            RenameColumn(table: "dbo.CPUs", name: "SocketId", newName: "Socket_Id");
            AddColumn("dbo.CPUs", "ChipsetId", c => c.Int(nullable: false));
            AlterColumn("dbo.CPUs", "Socket_Id", c => c.Int());
            CreateIndex("dbo.CPUs", "ChipsetId");
            CreateIndex("dbo.CPUs", "Socket_Id");
            AddForeignKey("dbo.CPUs", "ChipsetId", "dbo.Chipsets", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CPUs", "Socket_Id", "dbo.Sockets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CPUs", "Socket_Id", "dbo.Sockets");
            DropForeignKey("dbo.CPUs", "ChipsetId", "dbo.Chipsets");
            DropIndex("dbo.CPUs", new[] { "Socket_Id" });
            DropIndex("dbo.CPUs", new[] { "ChipsetId" });
            AlterColumn("dbo.CPUs", "Socket_Id", c => c.Int(nullable: false));
            DropColumn("dbo.CPUs", "ChipsetId");
            RenameColumn(table: "dbo.CPUs", name: "Socket_Id", newName: "SocketId");
            CreateIndex("dbo.CPUs", "SocketId");
            AddForeignKey("dbo.CPUs", "SocketId", "dbo.Sockets", "Id", cascadeDelete: true);
        }
    }
}
