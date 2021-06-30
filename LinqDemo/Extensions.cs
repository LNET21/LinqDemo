using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
   public static class Extensions
    {

        public static void IntExt(this int x)
        {
            Console.WriteLine(x);
        }

        public static string Add(this string str, string newWord)
        {
            return $"{str} {newWord}";
        }

        public static string Add(this string str, params string[] words)
        {
            return $"{str} {String.Join(" ", words)}";
        }

        public static IEnumerable<T> ReturnIfTrue<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            if (predicate is null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
