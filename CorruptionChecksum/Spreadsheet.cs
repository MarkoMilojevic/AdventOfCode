using System;
using System.Linq;

namespace CorruptionChecksum
{
    public class Spreadsheet
    {
        private int[][] Data { get; }

        public Spreadsheet(int[][] data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (data.Any(row => row == null))
                throw new ArgumentNullException($"{nameof(data)}[i]");

            Data = data;
        }

        public int Checksum(Func<int[], int> selector) =>
            Data
                .Select(selector)
                .Sum();
    }
}
