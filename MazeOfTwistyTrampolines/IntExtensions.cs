using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeOfTwistyTrampolines
{
    public static class IntExtensions
    {
        public static int NumberOfJumpsUntilOutOfBounds(this int[] offsets, Func<int, int> jump)
        {
            List<int> offsetsCopy = offsets.ToList();

            int jumpsCount = 0;
            int index = 0;
            while (index >= 0 && index < offsetsCopy.Count)
            {
                int offset = offsetsCopy[index];
                offsetsCopy[index] = jump(offset);
                index += offset;
                jumpsCount += 1;
            }

            return jumpsCount;
        }
    }
}
