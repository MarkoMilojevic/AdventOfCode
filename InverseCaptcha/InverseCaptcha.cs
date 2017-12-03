using InverseCaptcha.Solvers;
using System;

namespace InverseCaptcha
{
    public class InverseCaptcha
    {
        private readonly InverseCaptchaSolver _solver;

        public string Input { get; }

        public InverseCaptcha(string input, InverseCaptchaSolver solver)
        {
            Input = input ?? throw new ArgumentNullException(nameof(input));
            _solver = solver ?? throw new ArgumentNullException(nameof(_solver));
        }

        public int Solve()
        {
            return _solver.Solve(Input);
        }
    }
}
