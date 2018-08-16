using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExtensionsLib.UnitTests
{
    public class ReadOffsetsTests
    {
        [Fact]
        public void ReadOffsets()
        {
            var expected = new[] { 0, 3, 0, 1, -3 };

            var offsets = Extensions.ReadOffsets(Path.Combine(Environment.CurrentDirectory, "offsets.txt"));

            Assert.Equal(expected, offsets);
        }
    }
}
