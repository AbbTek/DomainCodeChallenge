using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCodeChallenge.Core.Domain
{
    public class Property
    {
        public PropertySource Source { get; set; }
        public string Address { get; set; }
        public string AgencyCode { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
