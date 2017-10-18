namespace UnitTesting
{
    public class Portfolio
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
    }
}
