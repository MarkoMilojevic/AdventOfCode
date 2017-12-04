using CorruptionChecksum.Selectors;
using Xunit;

namespace CorruptionChecksum.UnitTests
{
    public class SpreadsheetChecksumTests
    {
        [Fact]
        public void MaxMinDifferenceChecksum()
        {
            int[][] data = new int[][]
            {
                new[] { 5, 1, 9, 5 },
                new[] { 7, 5, 3 },
                new[] { 2, 4, 6, 8 }
            };

            Spreadsheet ss = new Spreadsheet(data);

            Assert.Equal(18, ss.Checksum(new MaxMinDifferenceChecksumSelector()));
        }

        [Fact]
        public void EvenlyDivisibleValuesChecksum()
        {
            int[][] data = new int[][]
            {
                new[] { 5, 9, 2, 8 },
                new[] { 9, 4, 7, 3 },
                new[] { 3, 8, 6, 5 }
            };

            Spreadsheet ss = new Spreadsheet(data);

            Assert.Equal(9, ss.Checksum(new EvenlyDivisibleValuesChecksumSelector()));
        }
    }
}
