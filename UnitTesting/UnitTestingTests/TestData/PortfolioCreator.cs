using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace UnitTestingTests.TestData
{
    public class PortfolioCreator : ICreator<Portfolio>
    {
        private ICreator<Person> _personCreator;

        public PortfolioCreator()
        {
            _personCreator = new PersonCreator();
        }

        public PortfolioCreator( ICreator<Person> personCreator )
        {
            _personCreator = personCreator;
        }

        public Portfolio Create()
        {
            return new Portfolio()
            {
                Id = Guid.NewGuid(),
                PortfolioOwner = _personCreator.Create()
            };
        }
    }
}
