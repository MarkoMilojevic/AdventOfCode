using System.Collections.Generic;
using System.Linq;

namespace InverseCaptcha
{
    public static class Extensions
    {
        public static List<int> GetDigits(this string number)
        {
            return number.Select(c => int.Parse(c.ToString())).ToList();
        }
    }
}
