using System;

namespace CorruptionChecksum.Selectors
{
    public class EvenlyDivisibleValuesChecksumSelector : IChecksumSelector
    {
        public Func<int[], int> Selector => array =>
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    var higher = Math.Max(array[i], array[j]);
                    var lower = Math.Min(array[i], array[j]);

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
