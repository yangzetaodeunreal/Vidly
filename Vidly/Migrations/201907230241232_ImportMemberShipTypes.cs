namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImportMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            //�����Ա����
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (0, N'��ͨ��Ա', 0, 365, 95)");
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (1, N'������Ա', 99, 365, 67)");
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (2, N'�ƽ��Ա', 189, 365, 57)");
            Sql("INSERT INTO MemberShipTypes (Id, Name, SignUpFee, DurationInDays, DiscountRate) VALUES (3, N'��Ϧȵ�Ż�Ա', 7, 7, 77)");
        }
        
        public override void Down()
        {
        }
    }
}
