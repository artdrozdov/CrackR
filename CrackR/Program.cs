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
            var Q = new QueueOfStacks<int>();
            for (int i = 1; i <= 20; i++)
            {
                Q.Push(i);
            }
            for(int i=1; i<=20; i++)
                Console.WriteLine(Q.Peek());
            Console.ReadKey();
        }
    }
}
