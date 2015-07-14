using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.CodeForces.Acm
{
    class BahosianAndDigits
    {
        public int MaximumK(string num)
        {
            return (int) GetPivot(num);
        }

        private int GetPivot(string num)
        {
            int result = 0;
            var mask = new bool[num.Length];
            foreach (var ch in num)
            {
                for (int i = 0; i < num.Length; i++)
                    mask[i] = num[i] == ch;

                int k = 0;
                for (int i = 0; i < mask.Length; i++)
                {
                    if (!mask[i])
                    {
                        k++;
                    }
                    else
                    {
                        if (k > result)
                        {
                            result = k;
                        }
                        k = 0;
                    }
                }
            }
            return result;
        }
    }
}
