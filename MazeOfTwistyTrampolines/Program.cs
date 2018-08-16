using System;
using ExtensionsLib;
using System.Linq;

namespace MazeOfTwistyTrampolines
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var offsets = Extensions.ReadOffsets("offsets.txt").ToList();
            var executedInstructionsCounter = 0;

            new JumpInstructions(offsets, () => executedInstructionsCounter++).Execute(offset => offset + 1);

            Console.WriteLine(executedInstructionsCounter);

            offsets = Extensions.ReadOffsets("offsets.txt").ToList();
            executedInstructionsCounter = 0;

            new JumpInstructions(offsets, () => executedInstructionsCounter++).Execute(offset => offset >= 3 ? offset - 1 : offset + 1);

            Console.WriteLine(executedInstructionsCounter);
        }
    }
}
