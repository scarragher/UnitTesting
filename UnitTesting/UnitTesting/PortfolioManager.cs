using System;

namespace UnitTesting
{
    public class PortfolioManager : IPortfolioManager
    {
        public void AddOrUpdatePolicy( string s )
        {
            throw new NotImplementedException();
        }

        public void AddPortfolio( Portfolio portfolio )
        {
            throw new NotImplementedException();
        }

        public void GetPolicyById( string s )
        {
            throw new NotImplementedException();
        }


        Portfolio IPortfolioManager.GetPortfolioById( Guid id )
        {
            throw new NotImplementedException();
        }
    }
}
