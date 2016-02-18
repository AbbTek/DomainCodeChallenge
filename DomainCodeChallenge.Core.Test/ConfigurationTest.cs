using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainCodeChallenge.Core.Configuration;

namespace DomainCodeChallenge.Core.Test
{
    [TestClass]
    public class ConfigurationTest
    {
        [TestMethod]
        public void GetConfiguration()
        {
            var setting = CManager.Settings;
        }
    }
}
