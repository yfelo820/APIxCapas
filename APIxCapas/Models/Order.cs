using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Models
{
    public class Order : Base
    {
        public int      Quantity   { get; set; }
        public int      ID_Client  { get; set; }
        public int      ID_Product { get; set; }
        public DateTime Date       { get; set; }
    }
}
