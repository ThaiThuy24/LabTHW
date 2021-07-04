namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (1, 'CONG NGHE PHAN MEM')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (2, 'AN TOAN THONG TIN')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (3, 'HE THONG THONG TIN QUAN LI')");
        }
        
        public override void Down()
        {
        }
    }
}
