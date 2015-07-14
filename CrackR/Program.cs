using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackR.Arrays;
using CrackR.BitwiseOperations;
using CrackR.CodeForces.Acm;
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
            var strnum = Console.ReadLine();
            var b = new BahosianAndDigits();
            Console.WriteLine(b.MaximumK(strnum));
            Console.ReadKey();
        }
    }
}
