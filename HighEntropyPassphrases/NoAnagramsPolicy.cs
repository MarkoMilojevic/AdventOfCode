using System.Linq;

namespace HighEntropyPassphrases
{
    public class NoAnagramsPolicy : IPassphrasePolicy
    {
        public bool IsSatisfied(string[] words)
        {
            string[] wordsWithLettersSortedAlphabetically = words
                                                            .Select(word => string.Concat(word.OrderBy(c => c)))
                                                            .ToArray();

            return new NoDuplicatesPolicy().IsSatisfied(wordsWithLettersSortedAlphabetically);
        }
    }
}
