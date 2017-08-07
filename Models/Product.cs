using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QualityBags.Models
{
    public class Product
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public string Description { get; set; }
        public string PathOfFile { get; set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
    }
}
