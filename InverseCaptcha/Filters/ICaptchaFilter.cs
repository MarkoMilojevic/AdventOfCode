using System.Collections.Generic;

namespace InverseCaptcha.Filters
{
    public interface ICaptchaFilter
    {
        List<int> Filter(List<int> digits);
    }
}
