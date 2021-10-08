using System;
using Xunit;


namespace Calculator.Tests
{

    public class CalculatorTest
    {

        [Fact]
        public void AddTest()
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
        [InlineData (new double[] {1,2,3,1,2}, 9)]
        public void AddArrayTest( double[] array, double expected)
        {
            
            // Action
            double actual = CalculatorProgram.Program.Add(array);

            // Assertion
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubstractTest()
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
        [InlineData(new double[] { 1, 2, 3, 1, 2 }, -7)]
        public void SubstractArrayTest(double[] array, double expected)
        {
            //act
            var actual = CalculatorProgram.Program.Subtract(array);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory(DisplayName = "Maths- Divided with parameters")]
        [InlineData(40, 8, 5)]
        public void DivideTest(double value1, double value2, double value3)
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
        public void MultiplyTest()
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
        public void DivideByZeroTest()
        {
            //arrange
           
            double expected = 0;

            //act
            var actual = CalculatorProgram.Program.Divide(15, 0);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ArrayOutOfBoundsTest()
        {
            //Arrange
            double[] array = { 2, 0, 2, 1 };
            string expectedText = "Index was outside the bounds of the array.";
            //Act
            var result = Assert.Throws<IndexOutOfRangeException>(() => array[99]);
            //Assert
            Assert.Equal(expectedText, result.Message);
        }

    }
}
