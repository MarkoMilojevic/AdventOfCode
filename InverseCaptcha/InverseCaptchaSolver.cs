using ExtensionsLib;
using System;
using System.Linq;

namespace InverseCaptcha
{
    public class InverseCaptchaSolver
    {
        public string Input { get; }
        public int Step { get; }

        public InverseCaptchaSolver(string input, int step)
        {
            if (step <= 0)
            {
                throw new ArgumentNullException(nameof(step));
            }

            Input = input ?? throw new ArgumentNullException(nameof(input));
            Step = step;
        }

        public int Solve()
        {
            return Input
                    .GetDigits()
                    .RemoveItemsNotMatchingItemWithinStep(Step)
                    .Sum();
        }
    }
}
