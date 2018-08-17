using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InverseCaptcha.UnitTests
{
    public class StringExtensionsTests
    {

        [Theory]
        [InlineData("1122", 3)]
        [InlineData("1111", 4)]
        [InlineData("1234", 0)]
        [InlineData("91212129", 9)]
        public void InverseCaptchaTests(string input, int expected) =>
            Assert.Equal(expected, input.InverseCaptcha(1));

        [Theory]
        [InlineData("1212", 6)]
        [InlineData("1221", 0)]
        [InlineData("123425", 4)]
        [InlineData("123123", 12)]
        [InlineData("12131415", 4)]
        public void InverseCaptchaHalfwayAroundTests(string input, int expected) =>
            Assert.Equal(expected, input.InverseCaptcha(input.Length / 2));

        [Theory]
        [MemberData(nameof(GetDigitsFromStringParams))]
        public void GetDigitsTests(string number, IEnumerable<int> expectedDigits) =>
            Assert.Equal(expectedDigits, number.GetDigits());

        public static IEnumerable<object> GetDigitsFromStringParams()
        {
            yield return new object[] { "", Enumerable.Empty<int>() };
            yield return new object[] { "1", new[] { 1 } };
            yield return new object[] { "12", new[] { 1, 2 } };
            yield return new object[] { "123", new[] { 1, 2, 3 } };
            yield return new object[] { "0", new[] { 0 } };
            yield return new object[] { "10", new[] { 1, 0 } };
            yield return new object[] { "100", new[] { 1, 0, 0 } };
        }
    }
}
