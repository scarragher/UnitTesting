using UnitTesting.EventModel;

namespace UnitTesting
{
    public class Usage
    {
        public void Test()
        {
            /* Original
            PortfolioManager.AddOrUpdatePolicy( "" );
            PortfolioManager.GetPolicyById( "" );

            EventManager.AddEvent( "" );
            EventManager.GetEventById( "" ); */

            // New - general usage
            Portfolio.Manager.AddOrUpdatePolicy( "" );
            Portfolio.Manager.GetPolicyById( "" );

            Event.Manager.AddEvent( "" );
            Event.Manager.GetEventById( "" );

        }
    }
}
