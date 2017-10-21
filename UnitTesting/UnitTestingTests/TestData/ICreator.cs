using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTests.TestData
{
    public interface ICreator<T>
    {

        T Create();
    }
}
