using System;
using Xunit;

namespace SpiralMemory.UnitTests
{
    public class SpiralMemoryTests
    {
        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(2, 1, 0)]
        [InlineData(11, 2, 0)]
        [InlineData(3, 1, 1)]
        [InlineData(12, 2, 1)]
        [InlineData(13, 2, 2)]
        [InlineData(15, 0, 2)]
        [InlineData(7, -1, -1)]
        [InlineData(21, -2, -2)]
        [InlineData(22, -1, -2)]
        public void MemoryLocationsGoInSpiral(int number, int x, int y)
        {
            var memory = SpiralMemory.Generate(number);

            Assert.Equal(new Position(x, y), memory[number - 1].Position);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(12, 3)]
        [InlineData(23, 2)]
        [InlineData(50, 7)]
        [InlineData(55, 6)]
        [InlineData(56, 7)]
        [InlineData(57, 8)]
        [InlineData(58, 7)]
        [InlineData(1024, 31)]
        [InlineData(325489, 552)]
        public void NumberOfStepsRequiredFromCenterTo(int number, int expectedNumberOfSteps)
        {
            var memory = SpiralMemory.Generate(number);

            var position = memory[number - 1].Position;

            Assert.Equal(expectedNumberOfSteps, Math.Abs(position.X) + Math.Abs(position.Y));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 10)]
        [InlineData(10, 11)]
        [InlineData(11, 23)]
        [InlineData(23, 25)]
        [InlineData(747, 806)]
        [InlineData(325489, 330785)]
        public void FirstNumberHigherThan(int number, int expectedNumber)
        {
            var memory = SpiralMemory.GenerateUntilHigherThan(number);

            Assert.Equal(expectedNumber, memory[memory.Count - 1].Value);
        }
    }
}
