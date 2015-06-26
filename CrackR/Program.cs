using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackR.Arrays;
using CrackR.BitwiseOperations;
using CrackR.Design.CallCenter;
using CrackR.Lists;
using CrackR.StacksAndQueues;
using CrackR.TreesAndGraphs;

namespace CrackR
{
    class Program
    {
        static void Main(string[] args)
        {
            var callCenter = new CallCenter(new ManagmentCenter(new Headquarters()));
            for(int i=0; i<10; i++)
                callCenter.DispatchCall();
            Console.ReadKey();
        }
    }
}
