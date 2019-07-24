namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FavoriteMovieTypeString : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "FavoriteMovie_Id", "dbo.Movies");
            DropIndex("dbo.Customers", new[] { "FavoriteMovie_Id" });
            AddColumn("dbo.Customers", "FavoriteMovie", c => c.String());
            DropColumn("dbo.Customers", "FavoriteMovie_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "FavoriteMovie_Id", c => c.Int());
            DropColumn("dbo.Customers", "FavoriteMovie");
            CreateIndex("dbo.Customers", "FavoriteMovie_Id");
            AddForeignKey("dbo.Customers", "FavoriteMovie_Id", "dbo.Movies", "Id");
        }
    }
}
