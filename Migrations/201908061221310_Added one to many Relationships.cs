namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedonetomanyRelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoolingTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sockets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Coolings", "TypeId", c => c.Int(nullable: false));
            AddColumn("dbo.CPUs", "SocketId", c => c.Int(nullable: false));
            AddColumn("dbo.GPUs", "RAMTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Coolings", "TypeId");
            CreateIndex("dbo.CPUs", "SocketId");
            CreateIndex("dbo.GPUs", "RAMTypeId");
            AddForeignKey("dbo.Coolings", "TypeId", "dbo.CoolingTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CPUs", "SocketId", "dbo.Sockets", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GPUs", "RAMTypeId", "dbo.RamMemoryTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Coolings", "Type");
            DropColumn("dbo.CPUs", "Socket");
            DropColumn("dbo.GPUs", "RAMType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GPUs", "RAMType", c => c.String());
            AddColumn("dbo.CPUs", "Socket", c => c.String());
            AddColumn("dbo.Coolings", "Type", c => c.String());
            DropForeignKey("dbo.GPUs", "RAMTypeId", "dbo.RamMemoryTypes");
            DropForeignKey("dbo.CPUs", "SocketId", "dbo.Sockets");
            DropForeignKey("dbo.Coolings", "TypeId", "dbo.CoolingTypes");
            DropIndex("dbo.GPUs", new[] { "RAMTypeId" });
            DropIndex("dbo.CPUs", new[] { "SocketId" });
            DropIndex("dbo.Coolings", new[] { "TypeId" });
            DropColumn("dbo.GPUs", "RAMTypeId");
            DropColumn("dbo.CPUs", "SocketId");
            DropColumn("dbo.Coolings", "TypeId");
            DropTable("dbo.Sockets");
            DropTable("dbo.CoolingTypes");
        }
    }
}
