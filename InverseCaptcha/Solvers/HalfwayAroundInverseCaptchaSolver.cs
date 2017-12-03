using System.Collections.Generic;

namespace InverseCaptcha.Solvers
{
    public class HalfwayAroundInverseCaptchaSolver : InverseCaptchaSolver
    {
        protected override List<int> Filter(List<int> digits)
        {
            return FilterWithStep(digits, digits.Count / 2);
        }
    }
}
