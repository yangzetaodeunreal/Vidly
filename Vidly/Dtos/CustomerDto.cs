using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? MemberShipTypeId { get; set; }

  
        public string FavoriteMovie { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool IsSubscribed { get; set; }
    }
}