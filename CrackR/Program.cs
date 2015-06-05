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
            var stack = new SetOfStacks<int>();
            stack.Push(6);
            stack.Push(5);
            stack.Push(7);
            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }
            //stack.Pop();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.PopAt(0));
            stack.Push(666);
            stack.Push(777);
            Console.WriteLine("The beast:" + stack.PopAt(0));
            stack.Push(111);
            stack.Push(112);
            stack.Push(113);
            Console.WriteLine(stack.Pop());
            Console.ReadKey();
        }
    }
}
