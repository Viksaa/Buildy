namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCaseandManufacturertotable : DbMigration
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
                        MotherboardType = c.String(),
                        FanSupport = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cases", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Cases", new[] { "ManufacturerId" });
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Cases");
        }
    }
}
