using System;

namespace SpiralMemory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int numberOfMemoryLocations = 325489;

            SpiralMemory memory1 = SpiralMemory.Generate(numberOfMemoryLocations);
            Position position = memory1[numberOfMemoryLocations - 1].Position;
            Console.WriteLine(Math.Abs(position.X) + Math.Abs(position.Y));

            SpiralMemory memory2 = SpiralMemory.GenerateUntilLastValueIsHigherThan(numberOfMemoryLocations);
            Console.WriteLine(memory2[memory2.Count - 1].Value);
        }
    }
}
