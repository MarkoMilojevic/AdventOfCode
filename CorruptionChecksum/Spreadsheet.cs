using CorruptionChecksum.Selectors;
using System.Linq;

namespace CorruptionChecksum
{
    public class Spreadsheet
    {
        private readonly int[][] _data;

        public Spreadsheet(int[][] data)
        {
            _data = data;
        }

        public int Checksum(IChecksumSelector selector)
        {
            return _data
                    .Select(selector.Selector)
                    .Sum();
        }
    }
}
