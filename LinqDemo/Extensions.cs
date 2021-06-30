using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
   public static class Extensions
    {
        public static string Add(this string str, string newWord)
        {
            return $"{str} {newWord}";
        }

        public static string Add(this string str, params string[] words)
        {
            return $"{str} {String.Join(" ", words)}";
        }
    }
}
