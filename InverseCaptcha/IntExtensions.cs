using System;
using System.Collections.Generic;
using System.Linq;

namespace InverseCaptcha
{
    public static class IntExtensions
    {
        public static IEnumerable<int> FilterItemsNotMatchingItemWithinStep(this IEnumerable<int> sequence, int step)
        {
            if (sequence == null)
                throw new ArgumentNullException(nameof(sequence));

            if (step <= 0)
                throw new ArgumentOutOfRangeException(nameof(step));

            List<int> list = sequence.ToList();

            return list.Where((item, index) => item == list[(index + step) % list.Count]);
        }
    }
}
