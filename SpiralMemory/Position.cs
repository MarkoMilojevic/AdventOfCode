using System;
using System.Collections.Generic;
using System.Linq;

namespace SpiralMemory
{
    public sealed class Position
    {
        public int X { get; }
        public int Y { get; }

        private readonly Lazy<List<Position>> _adjacentPositions;

        public Position(int x, int y)
        {
            X = x;
            Y = y;

            _adjacentPositions = new Lazy<List<Position>>(() => new List<Position> {
                new Position(X + 1, Y),
                new Position(X + 1, Y + 1),
                new Position(X, Y + 1),
                new Position(X - 1, Y + 1),
                new Position(X - 1, Y),
                new Position(X - 1, Y - 1),
                new Position(X, Y - 1),
                new Position(X + 1, Y - 1)
            });
        }

        public List<Position> AdjacentPositions => _adjacentPositions.Value;

        public static IEnumerable<Position> GenerateSpiral()
        {
            var x = 0;
            var y = 0;
            var direction = 1;
            var sequenceLength = 1;

            while (true)
            {
                while (2 * x * direction < sequenceLength)
                {
                    yield return new Position(x, y);
                    x += direction;
                }

                while (2 * y * direction < sequenceLength)
                {
                    yield return new Position(x, y);
                    y += direction;
                }

                direction *= -1;
                sequenceLength++;
            }
        }

        public static IEnumerable<Position> GenerateSpiral(int spiralSize) => GenerateSpiral().Take(spiralSize);

        public bool Equals(Position other) => X == other.X && Y == other.Y;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            return obj is Position position && Equals(position);
        }

        public override int GetHashCode()
        {
            var hashCode = 1861411795;

            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();

            return hashCode;
        }
    }
}
