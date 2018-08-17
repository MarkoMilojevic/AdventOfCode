using System;

namespace SpiralMemory
{
    public class MemoryLocation
    {
        public Position Position { get; }
        public int Value { get; }

        public MemoryLocation(Position position) : this(position, 0) { }

        public MemoryLocation(Position position, int value)
        {
            Position = position ?? throw new ArgumentNullException(nameof(position));
            Value = value;
        }

        public MemoryLocation WithValue(int value) =>
            new MemoryLocation(Position, value);
    }
}
