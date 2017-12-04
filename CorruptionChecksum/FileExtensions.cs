using System.IO;
using System.Linq;

namespace CorruptionChecksum
{
    public static class FileExtensions
    {
        public static int[][] ReadSpreadsheet(string path)
        {
            return File.ReadLines(path)
                        .Select(
                            line => line.Split(' ')
                                        .Select(int.Parse)
                                        .ToArray()
                        )
                        .ToArray();
        }
    }
}
