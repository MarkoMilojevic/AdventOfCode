using System;

namespace CorruptionChecksum.Selectors
{
    public interface IChecksumSelector
    {
        Func<int[], int> Selector { get; }
    }
}
