using ObjectAlgebras.UI;
using ObjectAlgebras.UI.ProxyGeneration;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ObjectAlgebras.Tests
{
    public class PrintAlgTests
    {
        private readonly DynamicProxyFactory _proxyFactory;

        public PrintAlgTests()
        {
            _proxyFactory = new DynamicProxyFactory();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void LitReturnsCorrectString(int x)
        {
            //Arrange
            var sut = new PrintAlg(_proxyFactory);
            var expected = x.ToString();

            //Act
            var result = sut.Lit(x);

            //Assert
            Assert.Equal(expected, result.Print());
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(3, 3)]
        public void AddReturnsCorrectString(int x, int y)
        {
            //Arrange
            var sut = new PrintAlg(_proxyFactory);
            var expected = x + " + " + y;

            //Act
            var result = sut.Add(sut.Lit(x), sut.Lit(y));

            //Assert
            Assert.Equal(expected, result.Print());
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(3, 3)]
        public void SubReturnsCorrectString(int x, int y)
        {
            //Arrange
            var sut = new PrintAlg(_proxyFactory);
            var expected = x + " - " + y;

            //Act
            var result = sut.Sub(sut.Lit(x), sut.Lit(y));

            //Assert
            Assert.Equal(expected, result.Print());
        }
    }
}
