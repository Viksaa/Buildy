namespace Buildy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactoringcomputer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Computers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Computers", "Name");
        }
    }
}
