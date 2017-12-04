using System;

namespace CorruptionChecksum.Selectors
{
    public class EvenlyDivisibleValuesChecksumSelector : IChecksumSelector
    {
        public Func<int[], int> Selector => array =>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int higher = Math.Max(array[i], array[j]);
                    int lower = Math.Min(array[i], array[j]);

                    if (higher % lower == 0)
                    {
                        return higher / lower;
                    }
                }
            }

            return 0;
        };
    }
}
