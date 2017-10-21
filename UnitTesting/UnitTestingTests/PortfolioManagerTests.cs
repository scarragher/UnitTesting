using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingTests.TestData;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class PortfolioManagerTests
    {
        [TestMethod()]
        public void AddOrUpdatePolicyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPolicyByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPortfolioById()
        {
            Portfolio.Manager = new MockPortfolioManager();

            // create the portfolio
            var portfolio = new PortfolioCreator().Create();

            // add the portfolio
            Portfolio.Manager.AddPortfolio( portfolio );

            // get the portfolio
            var loadedPortfolio = Portfolio.Manager.GetPortfolioById( portfolio.Id );

            // everything loaded correectly...
        }

        // some really specific person creator that other developers can use in here or something
        private class InvalidPersonCreator : ICreator<Person>
        {
            public Person Create()
            {
                return new Person()
                {
                    Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
                };
            }
        }

        [TestMethod()]
        public void GetPortfolioById_PersonWithWierdName()
        {
            Portfolio.Manager = new MockPortfolioManager();

            // create the portfolio with a person that has invalid details or w/e
            var portfolio = new PortfolioCreator( new InvalidPersonCreator() ).Create();

            // add the portfolio
            Portfolio.Manager.AddPortfolio( portfolio );

            // get the portfolio
            var loadedPortfolio = Portfolio.Manager.GetPortfolioById( portfolio.Id );

            // everything loaded correctly...
            Assert.IsFalse( portfolio.Equals( loadedPortfolio ) );
            Assert.IsTrue( loadedPortfolio.WasLoadedFromDatabase );
            Assert.IsFalse( portfolio.WasLoadedFromDatabase );
        }
    }
}