using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rent.Models
{
    public class Rents
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Marka { get; set; }
        [Required]
        [StringLength(100)]
        public string Model { get; set; }
        [Required]
        [StringLength(100)]
        public string Desc { get; set; }
        [Required]
        public int Mile { get; set; }
        [Required]
        public int Price { get; set; }
        [StringLength(100)]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }
    }
}