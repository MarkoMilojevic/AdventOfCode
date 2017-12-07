using System;

namespace SpiralMemory
{
    public class SpiralMemory
    {
        public int NumberOfStepsFromCenterTo(int number)
        {
            if (number == 1)
            {
                return 0;
            }

            int root = (int)Math.Ceiling(Math.Sqrt(number));
            if (root % 2 == 0)
            {
                root += 1;
            }

            int stepsToCircle = (root - 1) / 2;
            int minValueInCircle = (root - 2) * (root - 2) + 1;

            int outerRightValueClosestToCenter = minValueInCircle + (root - 3) / 2;
            int k = (number - minValueInCircle) / (root - 1);
            int valueToCountOffsetFrom = outerRightValueClosestToCenter + k * (root - 1);

            int offset = Math.Abs(number - valueToCountOffsetFrom);
            return stepsToCircle + offset;
        }
    }
}
