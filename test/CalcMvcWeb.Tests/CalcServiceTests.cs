using CalcMvcWeb.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcMvcWeb.Tests
{
    public class CalcServiceTests
    {
        [Trait("Math Ops", "Simple")]
        [Theory(DisplayName = "Add Numbers")]
        [InlineData(4, 5, 9)]
        [InlineData(2, 3, 5)]
        public void TestAddNumbers(int x, int y, int expectedResult)
        {
            // 1. Arrange
            var cs = new CalcService();

            // 2. Act 
            var result = cs.AddNumbers(x, y);

            // 3. Assert 
            Assert.Equal(expectedResult, result);
        }

        [Trait("Math Ops", "Simple")]
        [Theory]
        [InlineData(4, 5, -1)]
        [InlineData(12, 3, 9)]
        public void TestSubtractNumbers(int x, int y, int expectedResult)
        {
            var cs = new CalcService();
            var result = cs.SubtractNumbers(x, y);
            Assert.Equal(expectedResult, result);
        }

        [Trait("Math Ops", "Harder")]
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(12, 2, 24)]
        public void TestMultiplyNumbers(int x, int y, int expectedResult)
        {
            var cs = new CalcService();
            var actualResult = cs.MultiplyNumbers(x, y);
            Assert.Equal(expectedResult, actualResult);
        }

        [Trait("Math Ops", "Misc")]
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        public void TestEvenNumberWithBoolCompare(int x, bool expectedResult)
        {
            var cs = new CalcService();
            var actualResult = cs.IsEven(x);
            Assert.Equal(expectedResult, actualResult);
        }

        [Trait("Math Ops", "Misc")]
        //[Theory(Skip = "Don't run this test for now")]
        [Theory]
        [InlineData(2)]
        public void TestEvenNumberForTrueResult(int x)
        {
            var cs = new CalcService();
            var actualResult = cs.IsEven(x);
            Assert.True(actualResult);
        }

        [Theory]
        //[InlineData(1, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(22, true)]
        [InlineData(32, true)]
        public void TestEvenOrOdd(int x, bool isEven)
        {
            var cs = new CalcService();
            var actualResult = cs.IsEvenOrOdd(x);
            Assert.Equal(isEven, actualResult);
        }

        //[Theory(Skip="this is broken")]
        [Trait("Math Ops", "Harder")]
        [Theory]
        [InlineData(1, 0)]
        public void TestDivideByZero(int x, int y)
        {
            var cs = new CalcService();
            //var actualResult = cs.UnsafeDivide(x, y);

            Exception ex = Assert
                .Throws<DivideByZeroException>(() => cs.UnsafeDivide(x, y));

        }
    }
}
