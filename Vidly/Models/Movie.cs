using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "电影名")]
        public string Name { get; set; }

        [Display(Name = "上映时间")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "库存")]
        public int NumberInStock { get; set; }

        [Display(Name = "电影类型")]
        public Genre Genre { get; set; }

        [Display(Name = "电影类型")]
        public int GenreId { get; set; }
        //public IEnumerable<Customer> Customers { get; set; }
        //public int CustomerId { get; set; }
    }
}