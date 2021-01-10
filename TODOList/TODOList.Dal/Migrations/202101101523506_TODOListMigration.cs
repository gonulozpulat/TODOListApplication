namespace TODOList.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TODOListMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Description = c.String(maxLength: 500),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        ComplationDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsDone = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
