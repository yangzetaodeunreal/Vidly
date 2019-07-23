namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemberShipTypeIdToInt : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MemberShipTypes");
            AlterColumn("dbo.MemberShipTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MemberShipTypes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MemberShipTypes");
            AlterColumn("dbo.MemberShipTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MemberShipTypes", "Id");
        }
    }
}
