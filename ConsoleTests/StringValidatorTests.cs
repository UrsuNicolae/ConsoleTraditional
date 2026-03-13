using ConsoleAppTraditional.UTs;

namespace ConsoleTests
{
    public class StringValidatorTests
    {
        [Theory]
        [InlineData("skdjflkajsdlkff", false)]
        [InlineData("123", false)]
        [InlineData("123.", false)]
        [InlineData("123@.", true)]
        [InlineData("@.", true)]
        public void StringValidatorIsValidEmailShouldReturnFalseIfStringDoesNotContainDotsAndArons(string value, bool expectedResult)
        {
            var result = StringValidator.IsValidEmail(value);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("12345678", false)]
        [InlineData("1234567", false)]
        [InlineData("123456", false)]
        [InlineData("12345", false)]
        [InlineData("1234", false)]
        [InlineData("123", false)]
        [InlineData("12", false)]
        [InlineData("1", false)]
        public void StringValidatorIsPhoneNumberShouldReturnFalseIfStringIsShorterThan10(string value, bool expectedResult)
        {
            var result = StringValidator.IsPhoneNumber(value);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("12345d678", false)]
        [InlineData("123d4567", false)]
        [InlineData("123d456", false)]
        [InlineData("123d45", false)]
        [InlineData("1d234", false)]
        [InlineData("12d3", false)]
        [InlineData("12d", false)]
        public void StringValidatorIsPhoneNumberShouldReturnFalseIfStringDoNotContainOnlyDigits(string value, bool expectedResult)
        {
            var result = StringValidator.IsPhoneNumber(value);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("0123456789", true)]
        [InlineData("123d4567", false)]
        [InlineData("123d456", false)]
        [InlineData("123d45", false)]
        [InlineData("1d234", false)]
        [InlineData("12d3", false)]
        [InlineData("12d", false)]
        public void StringValidatorIsPhoneNumberShouldReturnTureIfStringContainOnlyDigitsAndLengthIs10(string value, bool expectedResult)
        {
            var result = StringValidator.IsPhoneNumber(value);
            Assert.Equal(expectedResult, result);
        }
    }
}
