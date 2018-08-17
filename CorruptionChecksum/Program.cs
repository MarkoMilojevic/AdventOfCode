using ExtensionsLib;
using System;
using System.IO;

namespace CorruptionChecksum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] maxMinData = Extensions.ReadIntMatrixFromFile(Path.Combine(Environment.CurrentDirectory, "max_min.txt"));
            Console.WriteLine(maxMinData.Checksum(ChecksumSelectors.MaxMinDifference));

            int[][] evenlyDivisibleData = Extensions.ReadIntMatrixFromFile(Path.Combine(Environment.CurrentDirectory, "evenly_divisible.txt"));
            Console.WriteLine(evenlyDivisibleData.Checksum(ChecksumSelectors.EvenlyDivisibleValues));
        }
    }
}
