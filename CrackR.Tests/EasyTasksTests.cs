using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackR.EasyTasks;

namespace CrackR.Tests
{
    [TestClass]
    public class EasyTasksTests
    {
        public void Swapper()
        {
            int a = 7;
            int b = 5;
            EasyTasks.Swapper.SwapInts(ref a, ref b);
            Assert.AreEqual(a,5);
            Assert.AreEqual(b,7);
        }
    }
}
