using System.Collections.Generic;
using Xunit;

namespace InverseCaptcha.UnitTests
{
    public class IntExtensionsTests
    {
        [Theory]
        [MemberData(nameof(RemoveItemsNotMatchingNextItemParams))]
        public void RemoveItemsNotMatchingNextItemTest(int[] numbers, int[] expected) =>
            Assert.Equal(expected, numbers.FilterItemsNotMatchingItemWithinStep(1));

        public static IEnumerable<object> RemoveItemsNotMatchingNextItemParams()
        {
            yield return new object[] { new[] { 1, 1, 2, 2 }, new[] { 1, 2 } };
            yield return new object[] { new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 } };
            yield return new object[] { new[] { 1, 2, 3, 4 }, new int[] { } };
            yield return new object[] { new[] { 9, 1, 2, 1, 2, 1, 2, 9 }, new[] { 9 } };
        }

        [Theory]
        [MemberData(nameof(RemoveItemsNotMatchingHalfwayAroundItemParams))]
        public void RemoveItemsNotMatchingHalfwayAroundItemTest(int[] numbers, int[] expected) =>
            Assert.Equal(expected, numbers.FilterItemsNotMatchingItemWithinStep(numbers.Length / 2));

        public static IEnumerable<object> RemoveItemsNotMatchingHalfwayAroundItemParams()
        {
            yield return new object[] { new[] { 1, 2, 1, 2 }, new[] { 1, 2, 1, 2 } };
            yield return new object[] { new[] { 1, 2, 3, 4, 2, 5 }, new[] { 2, 2 } };
            yield return new object[] { new[] { 1, 2, 3, 1, 2, 3 }, new[] { 1, 2, 3, 1, 2, 3 } };
            yield return new object[] { new[] { 1, 2, 1, 3, 1, 4, 1, 5 }, new[] { 1, 1, 1, 1 } };
        }
    }
}
