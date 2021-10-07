using System;
using Xunit;


namespace Calculator.Tests
{

    public class CalculatorTest
    {

        [Fact]
        public void Add()
        {
            //arrange

            double num1 = 5;
            double num2 = 3;
            double expected = 8;

            //act
            var actual = CalculatorProgram.Program.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 6, 9)]
        public void AddArray(double num1, double num2, double expected, params double[] n)
        {
            // Action
            double actual = CalculatorProgram.Program.Add(num1, num2, n);

            // Assertion
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Substract()
        {
            //arrange
            double x1 = 10;
            double x2 = 8;
            double expected = 2;

            //act
            var actual = CalculatorProgram.Program.Subtract(x1, x2);

            //assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 6, -3)]
        
        public void SubstractArray(double num1, double num2, double expected, params double[] n)
        {
            //act
            var actual = CalculatorProgram.Program.Subtract(num1, num2, n);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory(DisplayName = "Maths- Divided with parameters")]
        [InlineData(40, 8, 5)]
        public void Divide(double value1, double value2, double value3)
        {
            //arrange
            double x1 = value1;
            double x2 = value2;
            double expected = value3;

            //act
            var actual = CalculatorProgram.Program.Divide(x1, x2);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply()
        {
            //arrange
            double x1 = 5;
            double x2 = 8;
            double expected = 40;

            //act
            var actual = CalculatorProgram.Program.Multiply(x1, x2);

            //assert
            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void DivideByZero()
        {
            //arrange
           
            double expected = 0;

            //act
            var actual = CalculatorProgram.Program.Divide(15, 0);

            //assert
            Assert.Equal(expected, actual);
        }

        //[Fact(DisplayName = "Maths - Divide by Zero Exception")]
        //public void DivideByZeroException()
        //{
        //    //arrange
        //    double a = 100;
        //    double b = 0;

        //    //act
        //    Action act = () => CalculatorProgram.Program.Divide(a, b);

        //    //assert
        //    Assert.Throws<DivideByZeroException>(act);
        //}
    }
}
