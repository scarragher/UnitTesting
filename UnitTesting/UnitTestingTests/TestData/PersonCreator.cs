using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace UnitTestingTests.TestData
{
    public class PersonCreator : ICreator<Person>
    {
        public Person Create()
        {
            return new Person()
            {
                Name = "Test Person"
            };
        }
    }
}
