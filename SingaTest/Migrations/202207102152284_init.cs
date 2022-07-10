namespace SingaTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonthDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Jan = c.Int(nullable: false),
                        Feb = c.Int(nullable: false),
                        March = c.Int(nullable: false),
                        April = c.Int(nullable: false),
                        May = c.Int(nullable: false),
                        June = c.Int(nullable: false),
                        July = c.Int(nullable: false),
                        August = c.Int(nullable: false),
                        September = c.Int(nullable: false),
                        October = c.Int(nullable: false),
                        November = c.Int(nullable: false),
                        December = c.Int(nullable: false),
                        SeriesesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Serieses", t => t.SeriesesId, cascadeDelete: true)
                .Index(t => t.SeriesesId);
            
            CreateTable(
                "dbo.Serieses",
                c => new
                    {
                        SeriesesId = c.Int(nullable: false, identity: true),
                        Ecs = c.String(),
                        Bcat = c.String(),
                        Series = c.String(),
                    })
                .PrimaryKey(t => t.SeriesesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonthDatas", "SeriesesId", "dbo.Serieses");
            DropIndex("dbo.MonthDatas", new[] { "SeriesesId" });
            DropTable("dbo.Serieses");
            DropTable("dbo.MonthDatas");
        }
    }
}
