using System;
using System.Collections.Generic;
using System.Linq;

namespace SpiralMemory
{
    public sealed class Position : IEquatable<Position>
    {
        private Lazy<IEnumerable<Position>> LazyAdjacentPositions { get; }

        public int X { get; }
        public int Y { get; }
        public IEnumerable<Position> AdjacentPositions => LazyAdjacentPositions.Value;

        public Position(int x, int y)
        {
            X = x;
            Y = y;

            LazyAdjacentPositions = new Lazy<IEnumerable<Position>>(() => new List<Position> {
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

        public static IEnumerable<Position> Spiral(int spiralSize) =>
            InfiniteSpiral().Take(spiralSize);

        public static IEnumerable<Position> InfiniteSpiral()
        {
            int x = 0;
            int y = 0;
            int direction = 1;
            int sequenceLength = 1;

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
                sequenceLength += 1;
            }
        }

        public static bool operator ==(Position left, Position right) =>
            !(left is null ^ right is null) && (left is null || left.Equals(right));

        public static bool operator !=(Position left, Position right) =>
            !(left == right);

        public bool Equals(Position other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return X == other.X
                && Y == other.Y;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Position);

        public override int GetHashCode()
        {
            int hashCode = 1861411795;

            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();

            return hashCode;
        }
    }
}
