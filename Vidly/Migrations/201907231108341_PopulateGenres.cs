namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
            Sql("INSERT INTO Genres (Name) VALUES (N'ս��')");
            Sql("INSERT INTO Genres (Name) VALUES (N'��ͥ')");
            Sql("INSERT INTO Genres (Name) VALUES (N'ϲ��')");
            Sql("INSERT INTO Genres (Name) VALUES (N'ð��')");
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
            Sql("INSERT INTO Genres (Name) VALUES (N'���')");
            Sql("INSERT INTO Genres (Name) VALUES (N'��¼')");
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
            Sql("INSERT INTO Genres (Name) VALUES (N'�ֲ�')");
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
            Sql("INSERT INTO Genres (Name) VALUES (N'�ƻ�')");
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
            Sql("INSERT INTO Genres (Name) VALUES (N'��ͥ')");
            Sql("INSERT INTO Genres (Name) VALUES (N'����')");
        }
        
        public override void Down()
        {
        }
    }
}
