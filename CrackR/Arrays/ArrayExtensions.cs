using CrackR.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.Arrays
{
    public static class ArrayExtensions
    {
        public static bool IsDistinct(this char[] letters)
        {
            Array.Sort<char>(letters);
            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i] == letters[i - 1])
                    return false;
            }
            return true;
        }

        public static bool IsRelevant(this string a, string b)
        {
            var map = new bool[b.Length];
            foreach (var c in a)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (c == b[i] && !map[i])
                    {
                        map[i] = true;
                        break;
                    }
                }
            }
            return map.All(x => x == true);
        }

        public static string EscapeSpaces(this string a) {
            var result = new StringBuilder();
            foreach (var c in a)
            {
                if (c == ' ')
                {
                    result.Append("%20");
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
            //or just
            //return a.Replace("%20");
        }

        public static string Compress(this string self)
        {
            var stack = new Stack<char>();
            var result = new StringBuilder();
            for (int i=0; i < self.Length; i++)
            {
                if (stack.Any() && stack.Peek() != self[i])
                {
                    result.AppendFormat("{0}{1}", stack.Peek(), stack.Count);
                    stack.Clear();
                }    
                stack.Push(self[i]);
                if (i == self.Length -1)
                {
                    result.AppendFormat("{0}{1}",stack.Peek(),stack.Count);
                    stack.Clear();
                }
            }
            if (result.Length > self.Length)
                return self;
            else
                return result.ToString();
        }

        public static int[,] Transponent(int[,] matrix)
        {
            var result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[j,matrix.GetLength(1)-i-1] = matrix[i,j];
                }
            }
            return result;
        }
    }
}
