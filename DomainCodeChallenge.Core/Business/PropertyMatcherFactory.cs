using DomainCodeChallenge.Core.Configuration;
using DomainCodeChallenge.Core.Configuration.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCodeChallenge.Core.Business
{
    public static class PropertyMatcherFactory
    {
        private static Dictionary<string, IPropertyMatcher> providers = new Dictionary<string, IPropertyMatcher>();

        static PropertyMatcherFactory()
        {
            InitProviders();
        }

        private static void InitProviders()
        {
            foreach (var item in CManager.Settings.Providers)
            {
                var provider = item as PropertyMatcherProvider;
                if (provider != null)
                {
                    var type = Type.GetType(provider.TypeName);
                    var concreteProvider = Activator.CreateInstance(type) as PropertyMatcher;
                    if (concreteProvider != null)
                        providers[concreteProvider.AgencyCode] = concreteProvider;
                }
            }
        }

        public static IPropertyMatcher GetProvider(string agencyCode)
        {
            return providers[agencyCode];
        }
    }
}
