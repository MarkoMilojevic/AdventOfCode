using System;
using System.Linq;

namespace CorruptionChecksum
{
    public static class IntExtensions
    {
        public static int Checksum(this int[][] data, Func<int[], int> selector)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (data.Any(row => row == null))
                throw new ArgumentNullException($"{nameof(data)}[i]");

            return data
                   .Select(selector)
                   .Sum();
        }
    }
}
