namespace HighEntropyPassphrases
{
    public interface IPassphrasePolicy
    {
        bool IsSatisfied(string[] words);
    }
}
