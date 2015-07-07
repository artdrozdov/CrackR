using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackR.Arrays;
using CrackR.BitwiseOperations;
using CrackR.Design.CallCenter;
using CrackR.EasyTasks;
using CrackR.Lists;
using CrackR.StacksAndQueues;
using CrackR.TreesAndGraphs;

namespace CrackR
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Swapper.SwapInts(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}",a,b);
            Console.ReadKey();
        }
    }
}
