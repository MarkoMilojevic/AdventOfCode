using System.Collections.Generic;

namespace InverseCaptcha.Filters
{
    public class HalfwayAroundCaptchaFilter : ICaptchaFilter
    {
        public List<int> Filter(List<int> digits)
        {
            return digits.RemoveItemsNotMatchingHalfwayAroundItem();
        }
    }
}
