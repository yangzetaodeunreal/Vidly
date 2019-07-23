namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.VidlyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.VidlyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.MemberShipTypes.AddOrUpdate(
            //    new MemberShipType { Name = "��ͨ��Ա", DiscountRate = 95, SignUpFee = 0, DurationInDays = 365 },
            //    new MemberShipType { Name = "������Ա", DiscountRate = 67, SignUpFee = 99, DurationInDays = 365 },
            //    new MemberShipType { Name = "�ƽ��Ա", DiscountRate = 57, SignUpFee = 189, DurationInDays = 365 },
            //    new MemberShipType { Name = "��Ϧȵ�Ż�Ա", DiscountRate = 77, SignUpFee = 7, DurationInDays = 7 }
            //    );

        }
    }
}
