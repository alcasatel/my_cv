namespace Metanit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Experiences : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserExperiences", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserExperiences", "EndDate", c => c.DateTime(nullable: false));
        }
    }
}
