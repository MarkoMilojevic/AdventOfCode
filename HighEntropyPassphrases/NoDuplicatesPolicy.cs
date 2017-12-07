using System.Linq;

namespace HighEntropyPassphrases
{
    public class NoDuplicatesPolicy : IPassphrasePolicy
    {
        public bool IsSatisfied(string[] words)
        {
            return words.Length == words.Distinct().Count();
        }
    }
}
