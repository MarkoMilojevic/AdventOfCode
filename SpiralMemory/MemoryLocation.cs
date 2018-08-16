using System;

namespace SpiralMemory
{
    public class MemoryLocation
    {
        public Position Position { get; }

        public int Value { get; set; }

        public MemoryLocation(Position position)
        {
            Value = 0;
            Position = position ?? throw new ArgumentNullException(nameof(position));
        }
    }
}
