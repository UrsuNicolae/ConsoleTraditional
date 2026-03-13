using ConsoleAppTraditional.UTs;

namespace ConsoleTests
{
    public class CalcualtorTests
    {
        [Fact]
        public void CalculatorAddShoutAddTwoNumbers()
        {
            //Arragne
            var calcualtor = new Calculator();

            //Act
            var result = calcualtor.Add(2, 3);

            //Asert
            Assert.Equal(5, result);
        }
        
        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(20, 3, 17)]
        public void CalculatorSubtractShouldSubtractTwoNumbers(int a, int b, int expected)
        {
            //Arragne
            var calcualtor = new Calculator();

            //Act
            var result = calcualtor.Subtract(a, b);

            //Asert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 3, 30)]
        [InlineData(20, 3, 60)]
        public void CalculatorMultiplyShouldMultiplyTwoNumbers(int a, int b, int expected)
        {
            //Arragne
            var calcualtor = new Calculator();

            //Act
            var result = calcualtor.Multiply(a, b);

            //Asert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 3, 3)]
        [InlineData(20, 3, 6)]
        public void CalculatorDivideShouldDivideTwoNumbers(int a, int b, int expected)
        {
            //Arragne
            var calcualtor = new Calculator();

            //Act
            var result = calcualtor.Divide(a, b);

            //Asert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculatorDivideShouldThrowExceptionWhenDividingByZero()
        {
            //Arragne
            var calcualtor = new Calculator();

            //Act
            //Asert
            Assert.Throws<DivideByZeroException>(() => calcualtor.Divide(1, 0));
        }
    }
}