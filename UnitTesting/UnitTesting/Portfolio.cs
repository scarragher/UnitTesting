using System;

namespace UnitTesting
{
    public class Portfolio : ICloneable
    {

        private static IPortfolioManager _manager;

        public static IPortfolioManager Manager
        {
            get
            {
                if( _manager == null )
                {
                    _manager = new PortfolioManager();
                }

                return _manager;
            }
            set
            {
                _manager = value;
            }
        }

        public Person PortfolioOwner { get; set; }

        public Guid Id { get; set; }

        public bool WasLoadedFromDatabase { get; set; }

        public object Clone()
        {
            return new Portfolio() { Id = this.Id, PortfolioOwner = this.PortfolioOwner };
        }
    }
}
