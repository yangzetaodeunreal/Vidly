using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShipType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int SignUpFee { get; set; }

        public int DurationInDays { get; set; }

        public int DiscountRate { get; set; }

        public static readonly int PayAsYouGo = 0;
    }
}