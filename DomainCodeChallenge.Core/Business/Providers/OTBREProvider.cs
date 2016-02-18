using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCodeChallenge.Core.Domain;

namespace DomainCodeChallenge.Core.Business.Providers
{
    public class OTBREProvider : PropertyMatcher
    {
        public override string AgencyCode
        {
            get
            {
                return "OTBRE";
            }
        }

        public override bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            throw new NotImplementedException();
        }
    }
}
