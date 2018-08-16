using Xunit;

namespace HighEntropyPassphrases.UnitTests
{
    public class PassphraseTests
    {
        [Theory]
        [InlineData(new object[] { new[] { "aa", "bb", "cc", "dd", "ee" } })]
        [InlineData(new object[] { new[] { "aa", "bb", "cc", "dd", "aaa" } })]
        public void Should_BeValid_When_PassphraseHasNoDuplicateWords(string[] words)
        {
            Assert.True(new NoDuplicatesPolicy().IsSatisfied(words));
        }

        [Fact]
        public void Should_NotBeValid_When_PassphraseHasDuplicateWords()
        {
            Assert.False(new NoDuplicatesPolicy().IsSatisfied(new[] { "aa", "bb", "cc", "dd", "aa" }));
        }

        [Theory]
        [InlineData(new object[] { new[] { "abcde", "fghij" } })]
        [InlineData(new object[] { new[] { "a", "ab", "abc", "abd", "abf", "abj" } })]
        [InlineData(new object[] { new[] { "iiii", "oiii", "ooii", "oooi", "oooo" } })]
        public void Should_BeValid_When_PassphraseHasNoTwoWordsThatAreAnagrams(string[] words)
        {
            Assert.True(new NoAnagramsPolicy().IsSatisfied(words));
        }

        [Theory]
        [InlineData(new object[] { new[] { "abcde", "xyz", "ecdab" } })]
        [InlineData(new object[] { new[] { "oiii", "ioii", "iioi", "iiio" } })]
        public void Should_NotBeValid_When_PassphraseHasTwoWordsThatAreAnagrams(string[] words)
        {
            Assert.False(new NoAnagramsPolicy().IsSatisfied(words));
        }
    }
}
