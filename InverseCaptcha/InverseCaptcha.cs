using InverseCaptcha.Filters;
using System;
using System.Linq;

namespace InverseCaptcha
{
    public class InverseCaptcha
    {
        private readonly ICaptchaFilter _filter;

        public string Input { get; }

        public InverseCaptcha(string input, ICaptchaFilter filter)
        {
            Input = input ?? throw new ArgumentNullException(nameof(input));
            _filter = filter ?? throw new ArgumentNullException(nameof(_filter));
        }

        public int Solve()
        {
            return _filter.Filter(Input.GetDigits()).Sum();
        }
    }
}
