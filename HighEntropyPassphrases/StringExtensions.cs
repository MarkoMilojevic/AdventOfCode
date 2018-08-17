using System;
using System.Linq;

namespace HighEntropyPassphrases
{
    public static class StringExtensions
    {
        public static bool HasDuplicates(this string[] input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input.Length == input.Distinct().Count();
        }

        public static bool HasAnagrams(this string[] input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input
                   .Select(@string => string.Join(string.Empty, @string.OrderBy(c => c)))
                   .ToArray()
                   .HasDuplicates();
        }
    }
}
