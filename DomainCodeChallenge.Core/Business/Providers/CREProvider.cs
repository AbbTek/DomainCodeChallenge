using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCodeChallenge.Core.Domain;
using System.Text.RegularExpressions;

namespace DomainCodeChallenge.Core.Business.Providers
{
    public class CREProvider : PropertyMatcher
    {
        Regex regex = new Regex(@"\W+", RegexOptions.Compiled);
        public override string AgencyCode
        {
            get
            {
                return "CRE";
            }
        }

        public override bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            var agencyNames = regex.Split(agencyProperty.Name).Reverse();
            var agencyName = string.Join(" ", agencyNames);

            var databaseNames = regex.Split(databaseProperty.Name);
            var databaseName = string.Join(" ", databaseNames);

            return agencyName.Equals(databaseName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
