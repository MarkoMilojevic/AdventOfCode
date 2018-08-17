using Xunit;

namespace HighEntropyPassphrases.UnitTests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData(new object[] { new[] { "aa", "bb", "cc", "dd", "ee" } })]
        [InlineData(new object[] { new[] { "aa", "bb", "cc", "dd", "aaa" } })]
        public void Should_BeValid_When_PassphraseHasNoDuplicateWords(string[] words) =>
            Assert.True(words.HasDuplicates());

        [Fact]
        public void Should_NotBeValid_When_PassphraseHasDuplicateWords() =>
            Assert.False(new[] { "aa", "bb", "cc", "dd", "aa" }.HasDuplicates());

        [Theory]
        [InlineData(new object[] { new[] { "abcde", "fghij" } })]
        [InlineData(new object[] { new[] { "a", "ab", "abc", "abd", "abf", "abj" } })]
        [InlineData(new object[] { new[] { "iiii", "oiii", "ooii", "oooi", "oooo" } })]
        public void Should_BeValid_When_PassphraseHasNoTwoWordsThatAreAnagrams(string[] words) =>
            Assert.True(words.HasAnagrams());

        [Theory]
        [InlineData(new object[] { new[] { "abcde", "xyz", "ecdab" } })]
        [InlineData(new object[] { new[] { "oiii", "ioii", "iioi", "iiio" } })]
        public void Should_NotBeValid_When_PassphraseHasTwoWordsThatAreAnagrams(string[] words) =>
            Assert.False(words.HasAnagrams());
    }
}
