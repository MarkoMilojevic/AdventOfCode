using System;
using System.Collections.Generic;
using System.Linq;

namespace InverseCaptcha
{
    public class InverseCaptcha
    {
        private readonly Func<List<int>, List<int>> _filter;

        public string Input { get; }
        
        public InverseCaptcha(string input, Func<List<int>, List<int>> filter)
        {
            Input = input ?? throw new ArgumentNullException(nameof(input));
            _filter = filter ?? throw new ArgumentNullException(nameof(filter));
        }

        public int Solve()
        {
            return _filter(Input.GetDigits()).Sum();
        }
    }
}
