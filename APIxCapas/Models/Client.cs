using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Models
{
    public class Client : Base
    {
        public string Name        { get; set; }
        public string Address     { get; set; }
        public string PhoneNumber { get; set; }
    }
}
