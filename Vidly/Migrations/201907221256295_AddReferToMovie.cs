namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReferToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FavoriteMovie_Id", c => c.Int());
            CreateIndex("dbo.Customers", "FavoriteMovie_Id");
            AddForeignKey("dbo.Customers", "FavoriteMovie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "FavoriteMovie_Id", "dbo.Movies");
            DropIndex("dbo.Customers", new[] { "FavoriteMovie_Id" });
            DropColumn("dbo.Customers", "FavoriteMovie_Id");
        }
    }
}
