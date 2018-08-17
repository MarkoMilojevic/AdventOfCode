using System;
using System.IO;
using Xunit;

namespace ExtensionsLib.UnitTests
{
    public class ReadIntegersFromFileTests
    {
        [Fact]
        public void ReadIntegersFromFileTest() => 
            Assert.Equal(
                new[] { 0, 3, 0, 1, -3 }, 
                Extensions.ReadIntegersFromFile(Path.Combine(Environment.CurrentDirectory, "integers.txt"))
            );
    }
}
