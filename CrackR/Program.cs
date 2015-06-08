using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackR.Arrays;
using CrackR.Lists;
using CrackR.StacksAndQueues;
using CrackR.TreesAndGraphs;

namespace CrackR
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();
            tree.Add(2);
            tree.Add(1);
            tree.Add(3);
            tree.Add(5);
            tree.Add(0);
            Console.WriteLine(tree.IsBalanced());
            Console.ReadKey();
        }
    }
}
