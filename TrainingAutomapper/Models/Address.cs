using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAutomapper.Models
{
    public class Address
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
