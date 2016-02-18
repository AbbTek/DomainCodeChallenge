using DomainCodeChallenge.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCodeChallenge.Core.Business
{
    public interface IPropertyMatcher
    {
        bool IsMatch(Property agencyProperty, Property databaseProperty);
    }
}
