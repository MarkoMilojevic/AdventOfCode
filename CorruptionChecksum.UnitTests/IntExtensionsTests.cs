using Xunit;

namespace CorruptionChecksum.UnitTests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void MaxMinDifferenceChecksumTest()
        {
            var data = new[]
            {
                new[] { 5, 1, 9, 5 },
                new[] { 7, 5, 3 },
                new[] { 2, 4, 6, 8 }
            };
            
            Assert.Equal(18, data.Checksum(ChecksumSelectors.MaxMinDifference));
        }

        [Fact]
        public void EvenlyDivisibleValuesChecksumTest()
        {
            var data = new[]
            {
                new[] { 5, 9, 2, 8 },
                new[] { 9, 4, 7, 3 },
                new[] { 3, 8, 6, 5 }
            };

            Assert.Equal(9, data.Checksum(ChecksumSelectors.EvenlyDivisibleValues));
        }
    }
}
