using AdaCalculator;

namespace AdaCalculatorTests
{
    public class AdaCalculatorUnitTests
    {
        public Calculator _sut;

        public AdaCalculatorUnitTests()
        {
            _sut = new Calculator();
        }

        [Theory]
        [InlineData("sum", 20, 3, 23)]
        [InlineData("sum", 3, 7, 10)]
        public void Sum_TwoNumbers_ReturnSum(string op, double a, double b, double c)
        {

            (string operation, double c) result = _sut.Calculate(op, a, b);

            Assert.Equal(c, result.c);
            Assert.Equal("sum", result.operation);
        }

        [Theory]
        [InlineData("subtract", 20, 3, 17)]
        [InlineData("subtract", 3, 7, -4)]
        public void Subtract_TwoNumbers_ReturnSubtract(string op, double a, double b, double c)
        {

            (string operation, double c) result = _sut.Calculate(op, a, b);

            Assert.Equal(c, result.c);
            Assert.Equal("subtract", result.operation);
        }

        [Theory]
        [InlineData("multiply", 20, 0, 0)]
        [InlineData("multiply", 3, -7, -21)]
        [InlineData("multiply", 3, 2, 6)]
        public void Multiply_TwoNumbers_ReturnMultiply(string op, double a, double b, double c)
        {

            (string operation, double c) result = _sut.Calculate(op, a, b);

            Assert.Equal(c, result.c);
            Assert.Equal("multiply", result.operation);
        }

        [Theory]
        [InlineData("divide", 20, 0, double.PositiveInfinity)]
        [InlineData("divide", 5, -1, -5)]
        [InlineData("divide", 6, 2, 3)]
        public void Divide_TwoNumbers_ReturnDivision(string op, double a, double b, double c)
        {

            (string operation, double c) result = _sut.Calculate(op, a, b);

            Assert.Equal(c, result.c);
            Assert.Equal("divide", result.operation);
        }
    }
}