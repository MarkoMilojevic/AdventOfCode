using System.Collections.Generic;
using Xunit;

namespace MazeOfTwistyTrampolines.UnitTests
{
    public class JumpInstructionsTests
    {
        [Fact]
        public void CpuShouldFollowJumpInstructionsUntilExit()
        {
            var offsets = new List<int> { 0, 3, 0, 1, -3 };
            var executedInstructionsCounter = 0;

            new JumpInstructions(offsets, () => executedInstructionsCounter++).Execute(offset => offset + 1);

            Assert.Equal(5, executedInstructionsCounter);
        }

        [Fact]
        public void CpuShouldFollowJumpInstructionsUntilExit2()
        {
            var offsets = new List<int> { 0, 3, 0, 1, -3 };
            var executedInstructionsCounter = 0;

            new JumpInstructions(offsets, () => executedInstructionsCounter++).Execute(offset => offset >= 3 ? offset - 1 : offset + 1);

            Assert.Equal(10, executedInstructionsCounter);
        }
    }
}
