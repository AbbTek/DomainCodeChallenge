using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCodeChallenge.Core.Configuration.Elements
{
    public class PropertyMatcherProvider : ConfigurationElement
    {
        private const string type = "type";

        [ConfigurationProperty(type)]
        public string TypeName { get { return (string)this[type]; } }
    }
}
