using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCodeChallenge.Core.Configuration
{
    public class CManager
    {
        public static DomainSettings Settings
        {
            get
            {
                return (DomainSettings)ConfigurationManager.GetSection("domain");
            }
        }
    }
}
