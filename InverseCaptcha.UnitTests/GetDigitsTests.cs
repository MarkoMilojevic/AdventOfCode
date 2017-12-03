using System.Collections.Generic;
using Xunit;

namespace InverseCaptcha.UnitTests
{
    public class GetDigitsTests
    {
        [Theory]
        [MemberData(nameof(GetDigitsFromStringParams))]
        public void GetDigitsFromString(string number, List<int> expectedDigits)
        {
            List<int> digits = number.GetDigits();

            Assert.Equal(expectedDigits, digits);
        }

        public static IEnumerable<object> GetDigitsFromStringParams()
        {
            yield return new object[] { "", new List<int> { } };
            yield return new object[] { "1", new List<int> { 1 } };
            yield return new object[] { "12", new List<int> { 1, 2 } };
            yield return new object[] { "123", new List<int> { 1, 2, 3 } };
            yield return new object[] { "0", new List<int> { 0 } };
            yield return new object[] { "10", new List<int> { 1, 0 } };
            yield return new object[] { "100", new List<int> { 1, 0, 0 } };
        }
    }
}
