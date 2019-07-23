namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImportMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            //导入会员类型
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (0, N'普通会员', 0, 365, 95)");
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (1, N'白银会员', 99, 365, 67)");
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (2, N'黄金会员', 189, 365, 57)");
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (3, N'七夕鹊桥会员', 7, 7, 77)");
        }
        
        public override void Down()
        {
        }
    }
}
