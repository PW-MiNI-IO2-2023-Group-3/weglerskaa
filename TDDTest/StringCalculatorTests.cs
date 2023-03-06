using System;
using Xunit;
using TDD;

namespace TDDTest
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            int result = stringCalvualtor.SumString("");
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("12", 12)]
        [InlineData("1", 1)]
        [InlineData("225", 225)]
        public void SingleNumberReturnsValue(string str, int expectedValue)
        {
            int result = stringCalvualtor.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12,12",24)]
        [InlineData("12,3", 15)]
        [InlineData("2,50", 52)]
        public void StringSumComa(string str, int expectedValue)
        {
            int result = stringCalvualtor.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12\n12", 24)]
        [InlineData("12\n3", 15)]
        [InlineData("2\n50", 52)]
        public void StringSumSpace(string str, int expectedValue)
        {
            int result = stringCalvualtor.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12\n12,1", 25)]
        [InlineData("12,3,1", 16)]
        [InlineData("2,50\n1", 53)]
        public void MultiSeparatedValues(string str, int expectedValue)
        {
            int result = stringCalvualtor.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12\n12,-1")]
        [InlineData("-12,3,1")]
        [InlineData("-2")]
        public void NegValThrowExp(string str)
        {
            Assert.Throws<ArgumentException>(() => stringCalvualtor.SumString(str));
        }

        [Theory]
        [InlineData("1010\n12,1",13)]
        [InlineData("1233,3,1",4)]
        [InlineData("2000\n2345",0)]
        [InlineData("1000", 1000)]
        public void NumbersGraterThen1000(string str, int expectedValue)
        {
            int result = stringCalvualtor.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("//#\n1010\n12#1", 13)]
        [InlineData("//a\n1233a3,1", 4)]
        [InlineData("//$\n2000$2345", 0)]
        [InlineData("//\n2000\n2345", 0)]

        public void hashfun(string str, int expectedValue)
        {
            int result = stringCalvualtor.SumString(str);
            Assert.Equal(expectedValue, result);
        }
    }
}
