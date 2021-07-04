namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "categoryId" });
            CreateIndex("dbo.Courses", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            CreateIndex("dbo.Courses", "categoryId");
        }
    }
}
