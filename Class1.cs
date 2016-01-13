using Xunit;
using MyFirstDnxUnitTests.Models;

namespace MyFirstDnxUnitTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        [Fact]
        public void MySecondTheory()
        {
            int value = Methods.Subtract(5, 3);
            Assert.Equal(3, value);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void MySecondTheory(int value)
        {
            Assert.True(Methods.IsEven(value));
        }
        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
