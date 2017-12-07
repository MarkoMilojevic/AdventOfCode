using System.Collections.Generic;
using Xunit;

namespace ExtensionsLib.UnitTests
{
    public class RemoveItemsNotMatchingItemWithinStepTests
    {
        [Theory]
        [MemberData(nameof(RemoveItemsNotMatchingNextItemParams))]
        public void RemoveItemsNotMatchingNextItem(List<int> numbers, List<int> expected)
        {
            Assert.Equal(expected, numbers.RemoveItemsNotMatchingItemWithinStep(1));
        }

        public static IEnumerable<object> RemoveItemsNotMatchingNextItemParams()
        {
            yield return new object[] { new List<int> { 1, 1, 2, 2 }, new List<int> { 1, 2 } };
            yield return new object[] { new List<int> { 1, 1, 1, 1 }, new List<int> { 1, 1, 1, 1 } };
            yield return new object[] { new List<int> { 1, 2, 3, 4 }, new List<int> { } };
            yield return new object[] { new List<int> { 9, 1, 2, 1, 2, 1, 2, 9 }, new List<int> { 9 } };
        }

        [Theory]
        [MemberData(nameof(RemoveItemsNotMatchingHalfwayAroundItemParams))]
        public void RemoveItemsNotMatchingHalfwayAroundItem(List<int> numbers, List<int> expected)
        {
            Assert.Equal(expected, numbers.RemoveItemsNotMatchingItemWithinStep(numbers.Count / 2));
        }

        public static IEnumerable<object> RemoveItemsNotMatchingHalfwayAroundItemParams()
        {
            yield return new object[] { new List<int> { 1, 2, 1, 2 }, new List<int> { 1, 2, 1, 2 } };
            yield return new object[] { new List<int> { 1, 2, 3, 4, 2, 5 }, new List<int> { 2, 2 } };
            yield return new object[] { new List<int> { 1, 2, 3, 1, 2, 3 }, new List<int> { 1, 2, 3, 1, 2, 3 } };
            yield return new object[] { new List<int> { 1, 2, 1, 3, 1, 4, 1, 5 }, new List<int> { 1, 1, 1, 1 } };
        }
    }
}
