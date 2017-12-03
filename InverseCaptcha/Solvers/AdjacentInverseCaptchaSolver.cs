using System.Collections.Generic;

namespace InverseCaptcha.Solvers
{
    public class AdjacentInverseCaptchaSolver : InverseCaptchaSolver
    {
        protected override List<int> Filter(List<int> digits)
        {
            return FilterWithStep(digits, 1);
        }
    }
}
