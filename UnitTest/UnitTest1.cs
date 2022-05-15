using Xunit;
using StrykerDemo;

namespace UnitTest
{
    public class UnitTest1 : Program
    {
        [Fact]
        public void AdditionTest()
        {
            Assert.Equal(10, add(5, 5));
        }

        [Fact]
        public void SubtractionTest()
        {
            Assert.Equal(10, subtract(15, 5));
        }

        [Fact]
        public void ModularTest()
        {
            Assert.Equal(3, mod(15, 4));
        }
    }
}
