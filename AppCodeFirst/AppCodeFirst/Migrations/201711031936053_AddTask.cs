namespace AppCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        DueDate = c.DateTime(nullable: false),
                        IsComplete = c.Boolean(nullable: false,defaultValue:false),
                        AssignedTo_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.TaskId)
                .ForeignKey("dbo.User", t => t.AssignedTo_UserId)
                .Index(t => t.AssignedTo_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "AssignedTo_UserId", "dbo.User");
            DropIndex("dbo.Task", new[] { "AssignedTo_UserId" });
            DropTable("dbo.Task");
        }
    }
}
