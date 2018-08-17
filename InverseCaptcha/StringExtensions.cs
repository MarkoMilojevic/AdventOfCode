using System;
using System.Collections.Generic;
using System.Linq;

namespace InverseCaptcha
{
    public static class StringExtensions
    {
        public static int InverseCaptcha(this string input, int step) =>
            input
                .GetDigits()
                .FilterItemsNotMatchingItemWithinStep(step)
                .Sum();

        public static IEnumerable<int> GetDigits(this string number)
        {
            if (number == null)
                throw new ArgumentNullException(nameof(number));

            return number.Select(c => int.Parse(c.ToString()));
        }
    }
}
