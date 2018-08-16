using System;
using System.Collections.Generic;
using System.Linq;

namespace CorruptionChecksum
{
    public static class ChecksumSelectors
    {
        public static Func<int[], int> MaxMinDifference { get; } = array => array.Max() - array.Min();

        public static Func<int[], int> EvenlyDivisibleValues { get; } = array => array
                                                                                 .SelectMany(array.GetEvenlyDivisibleDivisions)
                                                                                 .Single()
                                                                                 .Quotient;

        private static IEnumerable<Division> GetEvenlyDivisibleDivisions(this int[] array, int dividend)
        {
            int dividendIndex = Array.FindIndex(array, value => value == dividend);

            return array
                   .Where((divisor, divisorIndex) => divisor != 0 && divisorIndex != dividendIndex)
                   .Select(divisor => new Division(dividend, divisor))
                   .Where(division => division.Remainder == 0);
        }

        private class Division
        {
            public int Dividend { get; }
            public int Divisor { get; }
            public int Quotient { get; }
            public int Remainder { get; }

            public Division(int dividend, int divisor)
            {
                if (divisor == 0)
                    throw new ArgumentException(nameof(divisor));

                Dividend = dividend;
                Divisor = divisor;
                Quotient = Dividend / Divisor;
                Remainder = Dividend % Divisor;
            }
        }
    }
}
