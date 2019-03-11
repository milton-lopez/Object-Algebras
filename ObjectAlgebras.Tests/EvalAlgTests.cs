using System;
using Xunit;
using ObjectAlgebras.UI.ProxyGeneration;
using ObjectAlgebras.UI;

namespace ObjectAlgebras.Tests
{
    public class EvalAlgTests
    {
        private readonly DynamicProxyFactory _proxyFactory;

        public EvalAlgTests()
        {
            _proxyFactory = new DynamicProxyFactory();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void LitReturnsArgument(int x)
        {
            //Arrange
            var sut = new EvalAlg(_proxyFactory);
            var expected = x;

            //Act
            var result = sut.Lit(x);

            //Assert
            Assert.Equal(expected, result.Eval());
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(3, 3)]
        public void AddReturnsSumOfTwoArguments(int x, int y)
        {
            //Arrange
            var sut = new EvalAlg(_proxyFactory);
            var expected = x + y;

            //Act
            var result = sut.Add(sut.Lit(x), sut.Lit(y));

            //Assert
            Assert.Equal(expected, result.Eval());
        }
    }
}
