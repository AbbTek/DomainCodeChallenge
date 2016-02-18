using DomainCodeChallenge.Core.Configuration.Elements;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCodeChallenge.Core.Configuration
{
    public class DomainSettings : ConfigurationSection
    {
        private const string providers = "providers";

        [ConfigurationProperty(providers)]
        [ConfigurationCollection(typeof(PropertyMatcherProvider))]
        public PropertyMatcherProviderCollection Providers
        {
            get
            {
                return (PropertyMatcherProviderCollection)this[providers];
            }
        }
    }
}
