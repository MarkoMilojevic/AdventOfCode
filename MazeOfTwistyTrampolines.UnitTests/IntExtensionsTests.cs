using Xunit;

namespace MazeOfTwistyTrampolines.UnitTests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void JumpTest()
        {
            int[] offsets = { 0, 3, 0, 1, -3 };

            Assert.Equal(5, offsets.NumberOfJumpsUntilOutOfBounds(offset => offset + 1));
            Assert.Equal(10, offsets.NumberOfJumpsUntilOutOfBounds(offset => offset >= 3 ? offset - 1 : offset + 1));
        }
    }
}
