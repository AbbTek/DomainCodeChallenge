using DomainCodeChallenge.Core.Business;
using DomainCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DomainCodeChallenge.Controllers.Api
{
    public class PropertyMatcherController : ApiController
    {
        [HttpPost]
        public bool IsMarch([FromBody]PropertyComparer comparer)
        {
            var provider = PropertyMatcherFactory.GetProvider(comparer.Provider);
            return provider.IsMatch(comparer.AgencyProperty, comparer.DatabaseProperty);
        }
    }
}
