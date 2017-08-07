using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QualityBags.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Eamil { get; set; }
        [Required]
        [Column("PhoneNoHome")]
        [Display(Name = "Home Phone Number")]
        public string PhoneNoHome { get; set; }
        [Required]
        [Column("PhoneNoMobile")]
        [Display(Name = "Mobile Phone Number")]
        public string PhoneNoMobile { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
