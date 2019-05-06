using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDrill
{
    public class Location
    {
        public Location(string address) : this(address, "Generic Brand Retail Store")
        {
        }
        public Location(string address, string name)
        {
            Address = address;
            Name = name;
        }
        public string Address { get; set; }
        public string Name { get; set; }
    }
}
