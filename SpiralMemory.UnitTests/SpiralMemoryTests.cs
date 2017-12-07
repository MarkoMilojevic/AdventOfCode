using Xunit;

namespace SpiralMemory.UnitTests
{
    public class SpiralMemoryTests
    {
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
            Assert.Equal(expectedNumberOfSteps, new SpiralMemory().NumberOfStepsFromCenterTo(number));
        }
    }
}
