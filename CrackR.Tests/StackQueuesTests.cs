using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackR.StacksAndQueues;

namespace CrackR.Tests
{
    [TestClass]
    public class StackQueuesTests
    {
        [TestMethod]
        public void MinStackTests()
        {
            var stack = new MinStack<int>();
            stack.Push(5);
            stack.Push(7);
            Assert.AreEqual(5, stack.Min());
            stack.Push(5);
            stack.Pop();
            Assert.AreEqual(5, stack.Min());
        }
    }
}
