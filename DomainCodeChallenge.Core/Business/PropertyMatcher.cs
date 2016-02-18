using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCodeChallenge.Core.Domain;

namespace DomainCodeChallenge.Core.Business
{
    public abstract class PropertyMatcher : IPropertyMatcher
    {
        public abstract string AgencyCode { get; }

        public abstract bool IsMatch(Property agencyProperty, Property databaseProperty);
    }
}
