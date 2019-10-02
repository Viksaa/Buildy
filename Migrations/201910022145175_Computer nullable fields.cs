namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Computernullablefields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Computers", "CaseId", "dbo.Cases");
            DropForeignKey("dbo.Computers", "CoolingId", "dbo.Coolings");
            DropForeignKey("dbo.Computers", "CpuId", "dbo.CPUs");
            DropForeignKey("dbo.Computers", "GpuId", "dbo.GPUs");
            DropForeignKey("dbo.Computers", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Computers", "PsuId", "dbo.PSUs");
            DropForeignKey("dbo.Computers", "RamId", "dbo.RAMs");
            DropForeignKey("dbo.Computers", "StorageId", "dbo.Storages");
            DropIndex("dbo.Computers", new[] { "CaseId" });
            DropIndex("dbo.Computers", new[] { "CoolingId" });
            DropIndex("dbo.Computers", new[] { "CpuId" });
            DropIndex("dbo.Computers", new[] { "GpuId" });
            DropIndex("dbo.Computers", new[] { "MotherboardId" });
            DropIndex("dbo.Computers", new[] { "PsuId" });
            DropIndex("dbo.Computers", new[] { "RamId" });
            DropIndex("dbo.Computers", new[] { "StorageId" });
            AlterColumn("dbo.Computers", "CaseId", c => c.Int());
            AlterColumn("dbo.Computers", "CoolingId", c => c.Int());
            AlterColumn("dbo.Computers", "CpuId", c => c.Int());
            AlterColumn("dbo.Computers", "GpuId", c => c.Int());
            AlterColumn("dbo.Computers", "MotherboardId", c => c.Int());
            AlterColumn("dbo.Computers", "PsuId", c => c.Int());
            AlterColumn("dbo.Computers", "RamId", c => c.Int());
            AlterColumn("dbo.Computers", "StorageId", c => c.Int());
            CreateIndex("dbo.Computers", "CaseId");
            CreateIndex("dbo.Computers", "CoolingId");
            CreateIndex("dbo.Computers", "CpuId");
            CreateIndex("dbo.Computers", "GpuId");
            CreateIndex("dbo.Computers", "MotherboardId");
            CreateIndex("dbo.Computers", "PsuId");
            CreateIndex("dbo.Computers", "RamId");
            CreateIndex("dbo.Computers", "StorageId");
            AddForeignKey("dbo.Computers", "CaseId", "dbo.Cases", "Id");
            AddForeignKey("dbo.Computers", "CoolingId", "dbo.Coolings", "Id");
            AddForeignKey("dbo.Computers", "CpuId", "dbo.CPUs", "Id");
            AddForeignKey("dbo.Computers", "GpuId", "dbo.GPUs", "Id");
            AddForeignKey("dbo.Computers", "MotherboardId", "dbo.Motherboards", "Id");
            AddForeignKey("dbo.Computers", "PsuId", "dbo.PSUs", "Id");
            AddForeignKey("dbo.Computers", "RamId", "dbo.RAMs", "Id");
            AddForeignKey("dbo.Computers", "StorageId", "dbo.Storages", "Id");
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
            AlterColumn("dbo.Computers", "StorageId", c => c.Int(nullable: false));
            AlterColumn("dbo.Computers", "RamId", c => c.Int(nullable: false));
            AlterColumn("dbo.Computers", "PsuId", c => c.Int(nullable: false));
            AlterColumn("dbo.Computers", "MotherboardId", c => c.Int(nullable: false));
            AlterColumn("dbo.Computers", "GpuId", c => c.Int(nullable: false));
            AlterColumn("dbo.Computers", "CpuId", c => c.Int(nullable: false));
            AlterColumn("dbo.Computers", "CoolingId", c => c.Int(nullable: false));
            AlterColumn("dbo.Computers", "CaseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Computers", "StorageId");
            CreateIndex("dbo.Computers", "RamId");
            CreateIndex("dbo.Computers", "PsuId");
            CreateIndex("dbo.Computers", "MotherboardId");
            CreateIndex("dbo.Computers", "GpuId");
            CreateIndex("dbo.Computers", "CpuId");
            CreateIndex("dbo.Computers", "CoolingId");
            CreateIndex("dbo.Computers", "CaseId");
            AddForeignKey("dbo.Computers", "StorageId", "dbo.Storages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "RamId", "dbo.RAMs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "PsuId", "dbo.PSUs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "MotherboardId", "dbo.Motherboards", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "GpuId", "dbo.GPUs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "CpuId", "dbo.CPUs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "CoolingId", "dbo.Coolings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "CaseId", "dbo.Cases", "Id", cascadeDelete: true);
        }
    }
}
