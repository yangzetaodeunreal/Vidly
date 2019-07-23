namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReferToMemberShipTypeInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MemberShipType_Id", c => c.Int());
            CreateIndex("dbo.Customers", "MemberShipType_Id");
            AddForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            DropColumn("dbo.Customers", "MemberShipType_Id");
        }
    }
}
