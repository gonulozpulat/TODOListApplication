namespace TODOList.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateControl : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "StartTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "StartTime", c => c.DateTime());
        }
    }
}
