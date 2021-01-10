namespace TODOList.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EndTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "EndTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "EndTime");
        }
    }
}
