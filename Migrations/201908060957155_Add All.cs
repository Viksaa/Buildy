namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Dimensions = c.String(),
                        MotherboardTypeId = c.Int(nullable: false),
                        FanSupport = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .ForeignKey("dbo.MotherboardTypes", t => t.MotherboardTypeId, cascadeDelete: false)
                .Index(t => t.ManufacturerId)
                .Index(t => t.MotherboardTypeId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coolings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Size = c.Int(nullable: false),
                        RGB = c.Boolean(nullable: false),
                        Speed = c.Int(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Cores = c.Int(nullable: false),
                        Threads = c.Int(nullable: false),
                        Frequency = c.Single(nullable: false),
                        Cache = c.Int(nullable: false),
                        Socket = c.String(),
                        CoolingSolution = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.GPUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Frequency = c.Int(nullable: false),
                        MemoryClock = c.Int(nullable: false),
                        Timing = c.String(),
                        RAMSize = c.Int(nullable: false),
                        RAMType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Socket = c.String(),
                        Chipset = c.String(),
                        MemorySupport = c.Int(nullable: false),
                        DimmSlots = c.Int(nullable: false),
                        MotherboardTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .ForeignKey("dbo.MotherboardTypes", t => t.MotherboardTypeId, cascadeDelete: false)
                .Index(t => t.ManufacturerId)
                .Index(t => t.MotherboardTypeId);
            
            CreateTable(
                "dbo.MotherboardTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PSUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Modular = c.Boolean(nullable: false),
                        Efficiency = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Type = c.String(),
                        Capacity = c.Int(nullable: false),
                        ReadingSpeed = c.Int(nullable: false),
                        WritingSpeed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.RAMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        ImageURL = c.String(),
                        Frequency = c.Int(nullable: false),
                        MemoryType = c.String(),
                        Size = c.Int(nullable: false),
                        Timing = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: false)
                .Index(t => t.ManufacturerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RAMs", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Storages", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.PSUs", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Motherboards", "MotherboardTypeId", "dbo.MotherboardTypes");
            DropForeignKey("dbo.Cases", "MotherboardTypeId", "dbo.MotherboardTypes");
            DropForeignKey("dbo.Motherboards", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.GPUs", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.CPUs", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Coolings", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Cases", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.RAMs", new[] { "ManufacturerId" });
            DropIndex("dbo.Storages", new[] { "ManufacturerId" });
            DropIndex("dbo.PSUs", new[] { "ManufacturerId" });
            DropIndex("dbo.Motherboards", new[] { "MotherboardTypeId" });
            DropIndex("dbo.Motherboards", new[] { "ManufacturerId" });
            DropIndex("dbo.GPUs", new[] { "ManufacturerId" });
            DropIndex("dbo.CPUs", new[] { "ManufacturerId" });
            DropIndex("dbo.Coolings", new[] { "ManufacturerId" });
            DropIndex("dbo.Cases", new[] { "MotherboardTypeId" });
            DropIndex("dbo.Cases", new[] { "ManufacturerId" });
            DropTable("dbo.RAMs");
            DropTable("dbo.Storages");
            DropTable("dbo.PSUs");
            DropTable("dbo.MotherboardTypes");
            DropTable("dbo.Motherboards");
            DropTable("dbo.GPUs");
            DropTable("dbo.CPUs");
            DropTable("dbo.Coolings");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Cases");
        }
    }
}
