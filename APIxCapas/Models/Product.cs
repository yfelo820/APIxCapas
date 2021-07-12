using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Models
{
    public class Product : Base
    {
        public string  Name            { get; set; }
        [Column(TypeName = "decimal (7,2)")]
        public decimal Price           { get; set; }
        public int     AmountAvailable { get; set; }
        public string  Description     { get; set; }
    }
}
