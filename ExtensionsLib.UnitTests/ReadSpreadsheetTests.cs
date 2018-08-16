using System;
using System.IO;
using Xunit;

namespace ExtensionsLib.UnitTests
{
    public class ReadSpreadsheetTests
    {
        [Fact]
        public void ReadSpreadsheet()
        {
            var expected = new[]
            {
                new[] { 5, 1, 9, 5 },
                new[] { 7, 5, 3 },
                new[] { 2, 4, 6, 8 }
            };

            var spreadsheet = Extensions.ReadSpreadsheet(Path.Combine(Environment.CurrentDirectory, "spreadsheet.txt"));

            Assert.Equal(expected, spreadsheet);
        }
    }
}
