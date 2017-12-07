using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExtensionsLib
{
    public static class Extensions
    {
        public static List<int> GetDigits(this string number)
        {
            return number.Select(c => int.Parse(c.ToString())).ToList();
        }

        public static List<int> RemoveItemsNotMatchingItemWithinStep(this List<int> sequence, int step)
        {
            List<int> itemsMatchingNextItem = new List<int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                int current = sequence[i];
                int next = sequence[(i + step) % sequence.Count];

                if (current == next)
                {
                    itemsMatchingNextItem.Add(current);
                }
            }

            return itemsMatchingNextItem;
        }

        public static int[][] ReadSpreadsheet(string path)
        {
            return File.ReadLines(path)
                        .Select(
                            line => line.Split(' ')
                                        .Select(int.Parse)
                                        .ToArray()
                        )
                        .ToArray();
        }

        public static string[][] ReadPassphrases(string path)
        {
            return File.ReadLines(path)
                        .Select(line => line.Split(' '))
                        .ToArray();
        }
    }
}
