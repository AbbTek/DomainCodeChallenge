using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainCodeChallenge.Core.Business;

namespace DomainCodeChallenge.Core.Test
{
    [TestClass]
    public class PropertyMatcherFactoryTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var provider = PropertyMatcherFactory.GetProvider("OTBRE");
        }
    }
}
