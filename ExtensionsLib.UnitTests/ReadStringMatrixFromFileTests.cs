using System;
using System.IO;
using Xunit;

namespace ExtensionsLib.UnitTests
{
    public class ReadStringMatrixFromFileTests
    {
        [Fact]
        public void ReadStringMatrixFromFileTest() =>
            Assert.Equal(
                new[]
                {
                    new[] { "aa", "bb", "cc", "dd", "ee" },
                    new[] { "aa", "bb", "cc", "dd", "aa" },
                    new[] { "aa", "bb", "cc", "dd", "aaa" }
                },
                Extensions.ReadStringMatrixFromFile(Path.Combine(Environment.CurrentDirectory, "string_matrix.txt"))
            );
    }
}
