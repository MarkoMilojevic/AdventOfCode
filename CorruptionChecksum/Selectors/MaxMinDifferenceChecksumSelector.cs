using System;
using System.Linq;

namespace CorruptionChecksum.Selectors
{
    public class MaxMinDifferenceChecksumSelector : IChecksumSelector
    {
        public Func<int[], int> Selector => array => array.Max() - array.Min();
    }
}
