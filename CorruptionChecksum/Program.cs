using CorruptionChecksum.Selectors;
using System;
using System.IO;

namespace CorruptionChecksum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] data = FileExtensions.ReadSpreadsheet(Path.Combine(Environment.CurrentDirectory, "maxMinSpreadsheet.txt"));

            Spreadsheet ss = new Spreadsheet(data);

            Console.WriteLine(ss.Checksum(new MaxMinDifferenceChecksumSelector()));

            data = FileExtensions.ReadSpreadsheet(Path.Combine(Environment.CurrentDirectory, "evenlyDivisibleSpreadsheet.txt"));

            ss = new Spreadsheet(data);

            Console.WriteLine(ss.Checksum(new EvenlyDivisibleValuesChecksumSelector()));
        }
    }
}
