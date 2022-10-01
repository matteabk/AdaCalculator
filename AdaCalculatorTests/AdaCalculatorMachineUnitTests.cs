using AdaCalculator;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaCalculatorTests
{
    public class AdaCalculatorMachineUnitTests
    {
        public CalculatorMachine _sut;

        [Theory]
        [InlineData("sum", 2.9, 3.5, 6.4)]
        [InlineData("sum", 3, 7, 10)]
        public void Check_CalculatorsMachineWorks_ReturnSum(string op, double a, double b, double c)
        {
            Moq.Mock<ICalculator> mockTest = new Moq.Mock<ICalculator>();
            mockTest.Setup(x => x.Calculate(op, a, b)).Returns((op, c));
            _sut = new CalculatorMachine(mockTest.Object);

            (string operation, double c) result = _sut.Calculate(op, a, b);

            mockTest.Verify(X => X.Calculate(op, a, b), Times.Once);
            Assert.Equal(c, result.c);
            Assert.Equal("sum", result.operation);
        }
    }
}
