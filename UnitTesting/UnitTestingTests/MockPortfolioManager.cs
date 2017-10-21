using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTesting.Tests
{
    public class MockPortfolioManager : IPortfolioManager
    {
        private List<Portfolio> _portfolios = new List<Portfolio>();

        public void AddOrUpdatePolicy( string s )
        {
            throw new NotImplementedException();
        }

        public void AddPortfolio( Portfolio portfolio )
        {
            _portfolios.Add( portfolio );
        }

        public void GetPolicyById( string s )
        {
            throw new NotImplementedException();
        }

        public Portfolio GetPortfolioById( Guid id )
        {
            var portfolio = (Portfolio)_portfolios.FirstOrDefault( p => p.Id == id )?.Clone();

            portfolio.WasLoadedFromDatabase = true;

            return portfolio;
        }
    }
}
