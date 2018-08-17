using System.Collections.Generic;
using System.Linq;

namespace SpiralMemory
{
    public class SpiralMemory
    {
        private IDictionary<int, MemoryLocation> MemoryLocationsByIndex { get; }

        public int Count => MemoryLocationsByIndex.Count;
        public MemoryLocation this[int index] => MemoryLocationsByIndex[index];

        private SpiralMemory(IDictionary<int, MemoryLocation> memoryLocationsByIndex) =>
            MemoryLocationsByIndex = memoryLocationsByIndex;

        public static SpiralMemory Generate(int numberOfMemoryLocations) =>
            new SpiralMemory(
                Position
                    .Spiral(numberOfMemoryLocations)
                    .Select((position, index) => new KeyValuePair<int, MemoryLocation>(index, new MemoryLocation(position)))
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
            );

        public static SpiralMemory GenerateUntilLastValueIsHigherThan(int number)
        {
            var memoryLocationsByIndex = new Dictionary<int, MemoryLocation>();
            var memoryLocationsByPosition = new Dictionary<Position, MemoryLocation>();

            int index = 0;
            int lastMemoryValuePopulated = 0;

            using (IEnumerator<Position> enumerator = Position.InfiniteSpiral().GetEnumerator())
            {
                while (lastMemoryValuePopulated <= number)
                {
                    enumerator.MoveNext();
                    Position position = enumerator.Current;

                    int value = CalculateMemoryLocationValue(memoryLocationsByPosition, position);
                    MemoryLocation memoryLocation = new MemoryLocation(position).WithValue(value);

                    memoryLocationsByIndex[index++] = memoryLocation;
                    memoryLocationsByPosition[position] = memoryLocation;

                    lastMemoryValuePopulated = memoryLocation.Value;
                }
            }

            return new SpiralMemory(memoryLocationsByIndex);
        }

        private static int CalculateMemoryLocationValue(Dictionary<Position, MemoryLocation> memoryLocationsByPosition, Position position) =>
            position.X == 0 && position.Y == 0
                ? 1
                : position
                  .AdjacentPositions
                  .Where(memoryLocationsByPosition.ContainsKey)
                  .Sum(pos => memoryLocationsByPosition[pos].Value);
    }
}
