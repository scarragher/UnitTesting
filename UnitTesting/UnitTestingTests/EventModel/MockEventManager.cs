using System;

namespace UnitTesting.EventModel.Tests
{
    public class MockEventManager : IEventManager
    {
        public void AddEvent( string e )
        {
            throw new NotImplementedException();
        }

        public void GetEventById( string id )
        {
            throw new NotImplementedException();
        }
    }
}
