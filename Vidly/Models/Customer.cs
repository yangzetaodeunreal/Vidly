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

        [Display(Name = "昵称")]
        public string Name { get; set; }

        [Display(Name = "会员类型")]
        public MemberShipType MemberShipType { get; set; }

        [Display(Name = "最爱的电影")]
        public Movie FavoriteMovie { get; set; }

        [Display(Name = "生日")]
        public DateTime BirthDate { get; set; }

        public bool IsSubscribed { get; set; }
    }
}