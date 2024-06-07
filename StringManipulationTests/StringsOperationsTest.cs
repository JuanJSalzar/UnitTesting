using StringManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulationTests
{
    public class StringsOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            var stringsOperations = new StringOperations();
            var result = stringsOperations.ConcatenateStrings("Hello", "World");
            Assert.Equal("Hello World", result);
        }
    }
}
