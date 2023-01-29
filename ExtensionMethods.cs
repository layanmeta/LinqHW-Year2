using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHWMain
{
    public static class ExtensionMethods
    {
        public static void PrintItems<T>(this IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static T GetHighest<T>(this IEnumerable<T> collection, Func<T, int> predicates)
        {
            T highestNum = default;
            int currentHighNum = 0;

            foreach (T item in collection)
            {
                if (predicates.Invoke(item) > currentHighNum)
                {
                    currentHighNum = predicates.Invoke(item);
                    highestNum = item;
                }
            }
            return highestNum;
        }

        public static T GetHighestWithIComparable<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T highestNum = default;
            foreach (T item in collection)
            {
                if (item.CompareTo(highestNum) > 0)
                {
                    highestNum = item;
                }
            }
            return highestNum;
        }
    }
}
