using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "请输入昵称")]
        [Display(Name = "昵称")]
        public string Name { get; set; }

        [Display(Name = "会员类型")]
        public MemberShipType MemberShipType { get; set; }

        [Display(Name = "会员类型")]
        public int? MemberShipTypeId { get; set; }

        [Display(Name = "最爱的电影")]
        public string FavoriteMovie { get; set; }

        [Display(Name = "生日")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribed { get; set; }
    }
}