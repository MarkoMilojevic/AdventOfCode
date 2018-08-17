using System.IO;
using System.Linq;

namespace ExtensionsLib
{
    public static class Extensions
    {
        public static int[] ReadIntegersFromFile(string filePath) =>
            File
                .ReadLines(filePath)
                .Select(int.Parse)
                .ToArray();

        public static int[][] ReadIntMatrixFromFile(string filePath) =>
            File
                .ReadLines(filePath)
                .Select(line => line.Split(' ')
                                    .Select(int.Parse)
                                    .ToArray())
                .ToArray();

        public static string[][] ReadStringMatrixFromFile(string filePath) =>
            File
                .ReadLines(filePath)
                .Select(line => line.Split(' '))
                .ToArray();
    }
}
