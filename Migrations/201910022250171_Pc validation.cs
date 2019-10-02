namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pcvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Computers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Computers", "Name", c => c.String());
        }
    }
}
