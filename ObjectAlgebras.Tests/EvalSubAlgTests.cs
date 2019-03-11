using ObjectAlgebras.UI;
using ObjectAlgebras.UI.ProxyGeneration;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ObjectAlgebras.Tests
{
    public class EvalSubAlgTests
    {
        private readonly DynamicProxyFactory _proxyFactory;

        public EvalSubAlgTests()
        {
            _proxyFactory = new DynamicProxyFactory();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(3, 3)]
        public void SubReturnsDifferenceBetweenTwoArguments(int x, int y)
        {
            //Arrange
            var sut = new EvalSubAlg(_proxyFactory);
            var expected = x - y;

            //Act
            var result = sut.Sub(sut.Lit(x), sut.Lit(y));

            //Assert
            Assert.Equal(expected, result.Eval());
        }
    }
}
