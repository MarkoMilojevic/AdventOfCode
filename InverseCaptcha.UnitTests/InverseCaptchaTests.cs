using InverseCaptcha.Solvers;
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
            InverseCaptcha captcha = new InverseCaptcha(input.ToString(), new AdjacentInverseCaptchaSolver());

            Assert.Equal(expected, captcha.Solve());
        }

        [Theory]
        [InlineData(1212, 6)]
        [InlineData(1221, 0)]
        [InlineData(123425, 4)]
        [InlineData(123123, 12)]
        [InlineData(12131415, 4)]
        public void SolveHalfwayAround(int input, int expected)
        {
            InverseCaptcha captcha = new InverseCaptcha(input.ToString(), new HalfwayAroundInverseCaptchaSolver());

            Assert.Equal(expected, captcha.Solve());
        }
    }
}
