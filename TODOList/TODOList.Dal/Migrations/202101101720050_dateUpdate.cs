namespace TODOList.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "CreateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
