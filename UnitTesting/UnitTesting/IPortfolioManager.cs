﻿using System;

namespace UnitTesting
{
    public interface IPortfolioManager
    {
        void AddOrUpdatePolicy( string s );

        void GetPolicyById( string s );

        void AddPortfolio( Portfolio portfolio );

        Portfolio GetPortfolioById( Guid id );
    }
}
