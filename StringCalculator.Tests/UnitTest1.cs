using System;
using stringCalculator;
using Xunit;

namespace StringCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenAnEmptyStringReturnZero()
        {
            //Arrange
            var stringCalculator = new StringCalculatorClass();
            //Act 
            var emptyString = stringCalculator.Calculate("");
            //Assert
            Assert.Equal(0, emptyString);
        }

        [Fact]
        public void GivenASingleNumberReturnNumber()
        {
            //Arrange
            var stringCalculator = new StringCalculatorClass();
            //Act 
            var oneNumber = stringCalculator.Calculate("4");
            //Assert
            Assert.Equal(4, oneNumber);
        }

        [Fact]
        public void TwoNumbersReturnThereAddition()
        {
            //Arrange
            var stringCalculator = new StringCalculatorClass();
            //Act 
            var oneNumber = stringCalculator.Calculate("4,4");
            //Assert
            Assert.Equal(8, oneNumber);
        }

        [Fact]
        public void AnyNumberOfNumbersReturnsThereAddition()
        {
            //Arrange
            var stringCalculator = new StringCalculatorClass();
            //Act 
            var manyNumbers = stringCalculator.Calculate("1,2,3,4,5,6,7,8,9");
            //Assert
            Assert.Equal(45, manyNumbers);
        }

        [Fact]
        public void ReturnsAdditionWhenANewLineSeparatorIsUsed()
        {
            //Arrange
            var stringCalculator = new StringCalculatorClass();
            //Act 
            var newLineSperator = stringCalculator.Calculate("1\n2,3");
            //Assert
            Assert.Equal(6, newLineSperator);
        }

        [Fact]
        public void DissalowNegativeNumbers()
        {
            //Arrange
            var stringCalculator = new StringCalculatorClass();
            //Act 
            var throws = Assert.Throws<ArgumentException>(() => stringCalculator.Calculate("1,-2,-3"));
            //Assert
            Assert.Equal("error: negatives not allowed", throws.Message);
        }
    }
}
