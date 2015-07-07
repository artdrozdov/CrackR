using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.EasyTasks
{
    public class Swapper
    {
        public static void SwapInts(ref Int32 a, ref Int32 b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }
    }
}
