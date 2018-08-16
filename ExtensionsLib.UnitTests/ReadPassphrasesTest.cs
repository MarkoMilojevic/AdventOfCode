using System;
using System.IO;
using Xunit;

namespace ExtensionsLib.UnitTests
{
    public class ReadPassphrasesTest
    {
        [Fact]
        public void ReadPassphrases()
        {
            var expected = new[]
            {
                new[] { "aa", "bb", "cc", "dd", "ee" },
                new[] { "aa", "bb", "cc", "dd", "aa" },
                new[] { "aa", "bb", "cc", "dd", "aaa" }
            };

            var passphrases = Extensions.ReadPassphrases(Path.Combine(Environment.CurrentDirectory, "passphrases.txt"));

            Assert.Equal(expected, passphrases);
        }
    }
}
