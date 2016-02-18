using DomainCodeChallenge.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainCodeChallenge.Models
{
    public class PropertyComparer
    {
        public Property DatabaseProperty { get; set; }
        public Property AgencyProperty { get; set; }

        public string Provider { get; set; }
    }
}