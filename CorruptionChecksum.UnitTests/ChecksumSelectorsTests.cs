using System.Collections.Generic;
using Xunit;

namespace CorruptionChecksum.UnitTests
{
    public class ChecksumSelectorsTests
    {
        [Theory]
        [MemberData(nameof(MaxMinDifferenceChecksumSelectorParams))]
        public void MaxMinDifferenceChecksumSelectorTest(int[] input, int expected) =>
            Assert.Equal(expected, ChecksumSelectors.MaxMinDifference(input));

        public static IEnumerable<object[]> MaxMinDifferenceChecksumSelectorParams()
        {
            yield return new object[] { new[] { 5, 1, 9, 5 }, 8 };
            yield return new object[] { new[] { 7, 5, 3 }, 4 };
            yield return new object[] { new[] { 2, 4, 6, 8 }, 6 };
        }

        [Theory]
        [MemberData(nameof(EvenlyDivisibleValuesChecksumSelectorParams))]
        public void EvenlyDivisibleValuesChecksumSelectorTest(int[] input, int expected) =>
            Assert.Equal(expected, ChecksumSelectors.EvenlyDivisibleValues(input));

        public static IEnumerable<object[]> EvenlyDivisibleValuesChecksumSelectorParams()
        {
            yield return new object[] { new[] { 5, 9, 2, 8 }, 4 };
            yield return new object[] { new[] { 9, 4, 7, 3 }, 3 };
            yield return new object[] { new[] { 3, 8, 6, 5 }, 2 };
        }
    }
}
