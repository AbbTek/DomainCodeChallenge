using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCodeChallenge.Core.Configuration.Elements
{
    public class PropertyMatcherProviderCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new PropertyMatcherProvider();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PropertyMatcherProvider)element).AgencyCode;
        }
    }
}
