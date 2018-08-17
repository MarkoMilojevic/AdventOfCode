using System;
using ExtensionsLib;

namespace MazeOfTwistyTrampolines
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] offsets = Extensions.ReadIntegersFromFile("offsets.txt");

            Console.WriteLine(offsets.NumberOfJumpsUntilOutOfBounds(offset => offset + 1));
            Console.WriteLine(offsets.NumberOfJumpsUntilOutOfBounds(offset => offset >= 3 ? offset - 1 : offset + 1));
        }
    }
}
