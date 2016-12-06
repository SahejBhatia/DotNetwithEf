namespace zenithsociety.Migrations.Events
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZenithModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityID = c.Int(nullable: false, identity: true),
                        ActivityDescrption = c.String(maxLength: 70),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventFromDateaAndTime = c.DateTime(nullable: false),
                        EventToDateAndTime = c.DateTime(nullable: false),
                        EnteredByUserName = c.String(),
                        activity = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
            DropTable("dbo.Activities");
        }
    }
}
