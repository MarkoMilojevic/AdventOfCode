using System.Collections.Generic;
using System.Linq;

namespace SpiralMemory
{
    public class SpiralMemory
    {
        private readonly Dictionary<int, MemoryLocation> _memoryLocationsByIndex;

        private SpiralMemory(Dictionary<int, MemoryLocation> memoryLocationsByIndex)
        {
            _memoryLocationsByIndex = memoryLocationsByIndex;
        }

        public MemoryLocation this[int index] => _memoryLocationsByIndex[index];

        public int Count => _memoryLocationsByIndex.Count;

        public static SpiralMemory Generate(int numberOfMemoryLocations)
        {
            var memoryLocationsByIndex = new Dictionary<int, MemoryLocation>();
            var index = 0;

            foreach (var position in Position.GenerateSpiral(numberOfMemoryLocations))
            {
                var memoryLocation = new MemoryLocation(position);

                memoryLocationsByIndex[index] = memoryLocation;

                index++;
            }

            return new SpiralMemory(memoryLocationsByIndex);
        }

        public static SpiralMemory GenerateUntilHigherThan(int number)
        {
            var memoryLocationsByIndex = new Dictionary<int, MemoryLocation>();
            var memoryLocationsByPosition = new Dictionary<Position, MemoryLocation>();

            var index = 0;
            foreach (var position in Position.GenerateSpiral())
            {
                var memoryLocation = new MemoryLocation(position);

                if (position.X == 0 && position.Y == 0)
                {
                    memoryLocation.Value = 1;
                }
                else
                {
                    memoryLocation.Value = position
                                            .AdjacentPositions                                            .Where(pos => memoryLocationsByPosition.ContainsKey(pos))
                                            .Sum(pos => memoryLocationsByPosition[pos].Value);
                }

                memoryLocationsByIndex[index] = memoryLocation;
                memoryLocationsByPosition[position] = memoryLocation;

                index++;

                if (memoryLocation.Value > number)
                {
                    break;
                }

            }

            return new SpiralMemory(memoryLocationsByIndex);
        }
    }
}
