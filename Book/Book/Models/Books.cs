using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Book.Models
{
    public class Books
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string BookName { get; set; }
        [StringLength(100)]
        [Required]
        public string Genre { get; set; }
        
        [Required]
        public int Page { get; set; }
        [StringLength(100)]
        [Required]
        public string Author { get; set; }
        public string ISBN { get; set; }
        [StringLength(100)]
        
        public string Image { get; set; }
        [Required]
        public int Price { get; set; }
        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }
    }
}