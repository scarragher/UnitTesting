using System;

namespace UnitTesting
{
    public class MockPortfolioManager : IPortfolioManager
    {
        public void AddOrUpdatePolicy( string s )
        {
            throw new NotImplementedException();
        }

        public void GetPolicyById( string s )
        {
            throw new NotImplementedException();
        }
    }
}
