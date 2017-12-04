using System;
using System.IO;
using Xunit;

namespace CorruptionChecksum.UnitTests
{
    public class ReadSpreadsheetTests
    {
        [Fact]
        public void ReadSpreadsheet()
        {
            int[][] expected = new int[][]
            {
                new[] { 5, 1, 9, 5 },
                new[] { 7, 5, 3 },
                new[] { 2, 4, 6, 8 }
            };

            int[][] spreadsheet = FileExtensions.ReadSpreadsheet(Path.Combine(Environment.CurrentDirectory, "spreadsheet.txt"));

            Assert.Equal(expected, spreadsheet);
        }
    }
}
