namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES (N'爱情')");
            Sql("INSERT INTO Genres (Name) VALUES (N'战争')");
            Sql("INSERT INTO Genres (Name) VALUES (N'家庭')");
            Sql("INSERT INTO Genres (Name) VALUES (N'喜剧')");
            Sql("INSERT INTO Genres (Name) VALUES (N'冒险')");
            Sql("INSERT INTO Genres (Name) VALUES (N'幻想')");
            Sql("INSERT INTO Genres (Name) VALUES (N'悬念')");
            Sql("INSERT INTO Genres (Name) VALUES (N'惊悚')");
            Sql("INSERT INTO Genres (Name) VALUES (N'记录')");
            Sql("INSERT INTO Genres (Name) VALUES (N'西部')");
            Sql("INSERT INTO Genres (Name) VALUES (N'剧情')");
            Sql("INSERT INTO Genres (Name) VALUES (N'恐怖')");
            Sql("INSERT INTO Genres (Name) VALUES (N'动作')");
            Sql("INSERT INTO Genres (Name) VALUES (N'科幻')");
            Sql("INSERT INTO Genres (Name) VALUES (N'音乐')");
            Sql("INSERT INTO Genres (Name) VALUES (N'家庭')");
            Sql("INSERT INTO Genres (Name) VALUES (N'犯罪')");
        }
        
        public override void Down()
        {
        }
    }
}
