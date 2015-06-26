using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.BitwiseOperations
{
    public static class BitwiseOperations
    {
        public static int InsertBits(int n, int m, int i, int j)
        {
            var premask = ~((~0) << (j - i + 1)) << i;
            n = n & ~premask;
            return n | (m << i);
            
        }

        public static void Swap<T>(this T[] array, int indexA, int indexB)
        {
            var tmp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = tmp;
        }

        public static bool[] ToBoolArray(this int number)
        {
            var result = new bool[32];
            for (int i = 31; i >= 0; i--)
            {
                long calc = (long) Math.Pow(2, i);
                if (number >= calc)
                {
                    result[i] = true;
                    number -= (int)calc;
                }
            }
            return result;
        }

        public static int FromBoolArray(this int number, bool[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    result += (int) Math.Pow(2, i);
                }
            }
            number = result;
            return number;
        }


        public static int GetLarger(this int number)
        {
            var mask = number.ToBoolArray();
            for (int i = 0; i < mask.Length-1; i++)
            {
                if (mask[i] && !mask[i + 1])
                {
                    mask.Swap(i,i+1);
                    break;
                }
            }
            return number.FromBoolArray(mask);
        }

        public static int GetSmaller(this int number)
        {
            var mask = number.ToBoolArray();
            for (int i = 0; i < mask.Length - 1; i++)
            {
                if (!mask[i] && mask[i + 1])
                {
                    mask.Swap(i, i + 1);
                    break;
                }
            }
            return number.FromBoolArray(mask);
        }
    }
}
