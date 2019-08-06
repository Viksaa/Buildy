namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedonetomanyRamMemoryTypeRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RamMemoryTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.RAMs", "MemoryTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.RAMs", "MemoryTypeId");
            AddForeignKey("dbo.RAMs", "MemoryTypeId", "dbo.RamMemoryTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.RAMs", "MemoryType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RAMs", "MemoryType", c => c.String());
            DropForeignKey("dbo.RAMs", "MemoryTypeId", "dbo.RamMemoryTypes");
            DropIndex("dbo.RAMs", new[] { "MemoryTypeId" });
            DropColumn("dbo.RAMs", "MemoryTypeId");
            DropTable("dbo.RamMemoryTypes");
        }
    }
}
