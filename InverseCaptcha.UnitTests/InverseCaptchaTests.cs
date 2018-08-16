using Xunit;

namespace InverseCaptcha.UnitTests
{
    public class InverseCaptchaTests
    {
        [Theory]
        [InlineData(1122, 3)]
        [InlineData(1111, 4)]
        [InlineData(1234, 0)]
        [InlineData(91212129, 9)]
        public void Solve(int input, int expected)
        {
            var solver = new InverseCaptchaSolver(input.ToString(), 1);

            Assert.Equal(expected, solver.Solve());
        }

        [Theory]
        [InlineData(1212, 6)]
        [InlineData(1221, 0)]
        [InlineData(123425, 4)]
        [InlineData(123123, 12)]
        [InlineData(12131415, 4)]
        public void SolveHalfwayAround(int input, int expected)
        {
            var solver = new InverseCaptchaSolver(input.ToString(), input.ToString().Length / 2);

            Assert.Equal(expected, solver.Solve());
        }
    }
}
