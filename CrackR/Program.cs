using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackR.Arrays;
using CrackR.Lists;
using CrackR.StacksAndQueues;

namespace CrackR
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new SortedStack<int>();
            for (int i = 20; i > 0; i--)
            {
                st.Push(i);
            }
            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }
            Console.ReadKey();
        }
    }
}
