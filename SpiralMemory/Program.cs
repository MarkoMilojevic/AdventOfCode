using System;

namespace SpiralMemory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = 325489;
            var memory = SpiralMemory.Generate(number);

            var position = memory[number - 1].Position;

            Console.WriteLine(Math.Abs(position.X) + Math.Abs(position.Y));
            
            memory = SpiralMemory.GenerateUntilHigherThan(number);
            Console.WriteLine(memory[memory.Count - 1].Value);
        }
    }
}
