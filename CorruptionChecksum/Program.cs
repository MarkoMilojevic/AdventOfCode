using ExtensionsLib;
using System;
using System.IO;

namespace CorruptionChecksum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] data;
            Spreadsheet ss;

            data = Extensions.ReadSpreadsheet(Path.Combine(Environment.CurrentDirectory, "max_min.txt"));
            ss = new Spreadsheet(data);
            Console.WriteLine(ss.Checksum(ChecksumSelectors.MaxMinDifference));

            data = Extensions.ReadSpreadsheet(Path.Combine(Environment.CurrentDirectory, "evenly_divisible.txt"));
            ss = new Spreadsheet(data);
            Console.WriteLine(ss.Checksum(ChecksumSelectors.EvenlyDivisibleValues));
        }
    }
}
