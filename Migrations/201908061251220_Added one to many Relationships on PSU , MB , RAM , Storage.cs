namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedonetomanyRelationshipsonPSUMBRAMStorage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chipsets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PsuEficencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StorageTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Motherboards", "SocketId", c => c.Int(nullable: false));
            AddColumn("dbo.Motherboards", "ChipsetId", c => c.Int(nullable: false));
            AddColumn("dbo.PSUs", "EfficiencyId", c => c.Int(nullable: false));
            AddColumn("dbo.Storages", "TypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Motherboards", "SocketId");
            CreateIndex("dbo.Motherboards", "ChipsetId");
            CreateIndex("dbo.PSUs", "EfficiencyId");
            CreateIndex("dbo.Storages", "TypeId");
            AddForeignKey("dbo.Motherboards", "ChipsetId", "dbo.Chipsets", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Motherboards", "SocketId", "dbo.Sockets", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PSUs", "EfficiencyId", "dbo.PsuEficencies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Storages", "TypeId", "dbo.StorageTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Motherboards", "Socket");
            DropColumn("dbo.Motherboards", "Chipset");
            DropColumn("dbo.PSUs", "Efficiency");
            DropColumn("dbo.Storages", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Storages", "Type", c => c.String());
            AddColumn("dbo.PSUs", "Efficiency", c => c.String());
            AddColumn("dbo.Motherboards", "Chipset", c => c.String());
            AddColumn("dbo.Motherboards", "Socket", c => c.String());
            DropForeignKey("dbo.Storages", "TypeId", "dbo.StorageTypes");
            DropForeignKey("dbo.PSUs", "EfficiencyId", "dbo.PsuEficencies");
            DropForeignKey("dbo.Motherboards", "SocketId", "dbo.Sockets");
            DropForeignKey("dbo.Motherboards", "ChipsetId", "dbo.Chipsets");
            DropIndex("dbo.Storages", new[] { "TypeId" });
            DropIndex("dbo.PSUs", new[] { "EfficiencyId" });
            DropIndex("dbo.Motherboards", new[] { "ChipsetId" });
            DropIndex("dbo.Motherboards", new[] { "SocketId" });
            DropColumn("dbo.Storages", "TypeId");
            DropColumn("dbo.PSUs", "EfficiencyId");
            DropColumn("dbo.Motherboards", "ChipsetId");
            DropColumn("dbo.Motherboards", "SocketId");
            DropTable("dbo.StorageTypes");
            DropTable("dbo.PsuEficencies");
            DropTable("dbo.Chipsets");
        }
    }
}
