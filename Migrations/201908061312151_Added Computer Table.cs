namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedComputerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: true, identity: true),
                        CaseId = c.Int(nullable: true),
                        CoolingId = c.Int(nullable: true),
                        CpuId = c.Int(nullable: true),
                        GpuId = c.Int(nullable: true),
                        MotherboardId = c.Int(nullable: true),
                        PsuId = c.Int(nullable: true),
                        RamId = c.Int(nullable: true),
                        StorageId = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cases", t => t.CaseId, cascadeDelete: false)
                .ForeignKey("dbo.Coolings", t => t.CoolingId, cascadeDelete: false)
                .ForeignKey("dbo.CPUs", t => t.CpuId, cascadeDelete: false)
                .ForeignKey("dbo.GPUs", t => t.GpuId, cascadeDelete: false)
                .ForeignKey("dbo.Motherboards", t => t.MotherboardId, cascadeDelete: false)
                .ForeignKey("dbo.PSUs", t => t.PsuId, cascadeDelete: false)
                .ForeignKey("dbo.RAMs", t => t.RamId, cascadeDelete: false)
                .ForeignKey("dbo.Storages", t => t.StorageId, cascadeDelete: false)
                .Index(t => t.CaseId)
                .Index(t => t.CoolingId)
                .Index(t => t.CpuId)
                .Index(t => t.GpuId)
                .Index(t => t.MotherboardId)
                .Index(t => t.PsuId)
                .Index(t => t.RamId)
                .Index(t => t.StorageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computers", "StorageId", "dbo.Storages");
            DropForeignKey("dbo.Computers", "RamId", "dbo.RAMs");
            DropForeignKey("dbo.Computers", "PsuId", "dbo.PSUs");
            DropForeignKey("dbo.Computers", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Computers", "GpuId", "dbo.GPUs");
            DropForeignKey("dbo.Computers", "CpuId", "dbo.CPUs");
            DropForeignKey("dbo.Computers", "CoolingId", "dbo.Coolings");
            DropForeignKey("dbo.Computers", "CaseId", "dbo.Cases");
            DropIndex("dbo.Computers", new[] { "StorageId" });
            DropIndex("dbo.Computers", new[] { "RamId" });
            DropIndex("dbo.Computers", new[] { "PsuId" });
            DropIndex("dbo.Computers", new[] { "MotherboardId" });
            DropIndex("dbo.Computers", new[] { "GpuId" });
            DropIndex("dbo.Computers", new[] { "CpuId" });
            DropIndex("dbo.Computers", new[] { "CoolingId" });
            DropIndex("dbo.Computers", new[] { "CaseId" });
            DropTable("dbo.Computers");
        }
    }
}
