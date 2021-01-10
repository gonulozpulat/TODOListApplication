namespace TODOList.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "StartTime", c => c.DateTime());
            DropColumn("dbo.Tasks", "CreateDate");
            DropColumn("dbo.Tasks", "UpdateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Tasks", "CreateDate", c => c.DateTime());
            DropColumn("dbo.Tasks", "StartTime");
        }
    }
}
