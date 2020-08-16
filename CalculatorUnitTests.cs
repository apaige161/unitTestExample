using Packt;
using System;
using Xunit;

namespace CalculatorLibUnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAdding2Plus2()
        {
            //arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();

            //act
            double actual = calc.Add(a,b);

            //assert
            AssemblyLoadEventArgs.Equals(expected, actual);
        }

        [Fact]
        public void TestAdding2Plus3()
        {
            //arrange
            double a = 2;
            double b = 5;
            double expected = 7;
            var calc = new Calculator();

            //act
            double actual = calc.Add(a,b);

            //assert
            AssemblyLoadEventArgs.Equals(expected, actual);
        }
    }
}
