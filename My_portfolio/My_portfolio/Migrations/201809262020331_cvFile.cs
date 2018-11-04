namespace Metanit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cvFile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserOthers", "CVFile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserOthers", "CVFile");
        }
    }
}
