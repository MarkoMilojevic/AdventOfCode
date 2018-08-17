using System;
using System.IO;
using Xunit;

namespace ExtensionsLib.UnitTests
{
    public class ReadIntMatrixFromFileTests
    {
        [Fact]
        public void ReadIntMatrixFromFileTest() =>
            Assert.Equal(
                new[]
                {
                    new[] { 5, 1, 9, 5 },
                    new[] { 7, 5, 3 },
                    new[] { 2, 4, 6, 8 }
                },
                Extensions.ReadIntMatrixFromFile(Path.Combine(Environment.CurrentDirectory, "int_matrix.txt"))
            );
    }
}
