using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainCodeChallenge.Core.Business;
using DomainCodeChallenge.Core.Domain;

namespace DomainCodeChallenge.Core.Test
{
    [TestClass]
    public class PropertyMatcherFactoryTest
    {

        [TestMethod]
        public void OTBREProviderTest()
        {
            //Arrange
            var databaseProperty = new Property()
            {
                Name = "Super ­High APARTMENTS, Sydney",
                Address = "32 Sir John­ Young Crescent, Sydney, NSW."
            };

            var agencyProperty = new Property()
            {
                Name = "*Super *­High! APARTMENTS(Sydney)",
                Address = "32 Sir John­-Young Crescent, Sydney, NSW."
            };

            var provider = PropertyMatcherFactory.GetProvider("OTBRE");

            //Action
            var result = provider.IsMatch(agencyProperty, databaseProperty);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LREProviderTest()
        {
            //Arrange
            var databaseProperty = new Property()
            {
                AgencyCode = "21212er222",
                Latitude = -33.9014586,
                Longitude = 151.206287
            };

            var agencyProperty = new Property()
            {
                AgencyCode = "21212er222",
                Latitude = -33.901191,
                Longitude = 151.207628
            };

            var provider = PropertyMatcherFactory.GetProvider("LRE");

            //Action
            var result = provider.IsMatch(agencyProperty, databaseProperty);
            Assert.IsTrue(result);
        }
    }
}
