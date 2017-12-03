using System.Collections.Generic;

namespace InverseCaptcha.Filters
{
    public class AdjacentCaptchaFilter : ICaptchaFilter
    {
        public List<int> Filter(List<int> digits)
        {
            return digits.RemoveItemsNotMatchingNextItem();
        }
    }
}
