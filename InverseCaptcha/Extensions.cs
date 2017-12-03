using System.Collections.Generic;
using System.Linq;

namespace InverseCaptcha
{
    public static class Extensions
    {
        public static List<int> GetDigits(this int number)
        {
            List<int> digits = new List<int>();

            do
            {
                digits.Add(number % 10);
                number /= 10;
            }
            while (number > 0);

            digits.Reverse();

            return digits;
        }

        public static List<int> GetDigits(this string number)
        {
            return number.Select(c => int.Parse(c.ToString())).ToList();
        }

        public static List<T> RemoveItemsNotMatchingNextItem<T>(this List<T> sequence)
        {
            return sequence.RemoveItemsNotMatchingNextItemWithStep(1);
        }

        public static List<T> RemoveItemsNotMatchingHalfwayAroundItem<T>(this List<T> sequence)
        {
            return sequence.RemoveItemsNotMatchingNextItemWithStep(sequence.Count / 2);
        }

        private static List<T> RemoveItemsNotMatchingNextItemWithStep<T>(this List<T> sequence, int step)
        {
            List<T> itemsMatchingNextItem = new List<T>();

            for (int i = 0; i < sequence.Count; i++)
            {
                T current = sequence[i];
                T next = sequence[(i + step) % sequence.Count];

                if (current.Equals(next))
                {
                    itemsMatchingNextItem.Add(current);
                }
            }

            return itemsMatchingNextItem;
        }
    }
}
