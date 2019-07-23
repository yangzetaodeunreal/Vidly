namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemberShipTypeToIntsAndDurationInDays : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "DurationInDays", c => c.Int(nullable: false));
            AlterColumn("dbo.MemberShipTypes", "SignUpFee", c => c.Int(nullable: false));
            AlterColumn("dbo.MemberShipTypes", "DiscountRate", c => c.Int(nullable: false));
            DropColumn("dbo.MemberShipTypes", "DurationInMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.MemberShipTypes", "DiscountRate", c => c.Byte(nullable: false));
            AlterColumn("dbo.MemberShipTypes", "SignUpFee", c => c.Short(nullable: false));
            DropColumn("dbo.MemberShipTypes", "DurationInDays");
        }
    }
}
