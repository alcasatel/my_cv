namespace Metanit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EducationChange1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserEducations", "Level", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserEducations", "Level");
        }
    }
}
