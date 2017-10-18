namespace UnitTesting.EventModel
{
    public class Event
    {

        private static IEventManager _manager;

        public static IEventManager Manager
        {
            get
            {
                if ( _manager == null )
                {
                    _manager = new EventManager();
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
