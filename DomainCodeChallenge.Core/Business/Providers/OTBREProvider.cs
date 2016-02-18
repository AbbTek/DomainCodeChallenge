using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCodeChallenge.Core.Domain;
using System.Text.RegularExpressions;

namespace DomainCodeChallenge.Core.Business.Providers
{
    public class OTBREProvider : PropertyMatcher
    {
        private Regex _regx = new Regex(@"[^\w]", RegexOptions.Compiled);
        public override string AgencyCode
        {
            get
            {
                return "OTBRE";
            }
        }

        public override bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            var agencyAddress = _regx.Replace(agencyProperty.Address, "");
            var agencyName = _regx.Replace(agencyProperty.Name, "");
            var databasAddress = _regx.Replace(databaseProperty.Address, "");
            var databasName = _regx.Replace(databaseProperty.Name, "");

            return
                agencyAddress.Equals(databasAddress, StringComparison.OrdinalIgnoreCase) &&
                agencyName.Equals(databasName, StringComparison.OrdinalIgnoreCase); 
         }
    }
}
