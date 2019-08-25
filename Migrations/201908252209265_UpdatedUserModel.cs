namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedUserModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "ImageUrl", c => c.String());
            AddColumn("dbo.AspNetUsers", "AddressId", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            CreateIndex("dbo.AspNetUsers", "AddressId");
            AddForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.AspNetUsers", new[] { "AddressId" });
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Age");
            DropColumn("dbo.AspNetUsers", "AddressId");
            DropColumn("dbo.AspNetUsers", "ImageUrl");
            DropTable("dbo.Addresses");
        }
    }
}
