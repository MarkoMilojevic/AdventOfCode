using System.Collections.Generic;
using System.Linq;

namespace InverseCaptcha.Solvers
{
    public abstract class InverseCaptchaSolver
    {
        public int Solve(string input)
        {
            return Filter(input.GetDigits()).Sum();
        }

        protected abstract List<int> Filter(List<int> digits);

        protected List<int> FilterWithStep(List<int> digits, int step)
        {
            List<int> itemsMatchingNextItem = new List<int>();

            for (int i = 0; i < digits.Count; i++)
            {
                int current = digits[i];
                int next = digits[(i + step) % digits.Count];

                if (current == next)
                {
                    itemsMatchingNextItem.Add(current);
                }
            }

            return itemsMatchingNextItem;
        }
    }
}
