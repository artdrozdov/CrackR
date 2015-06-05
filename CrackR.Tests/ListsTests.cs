using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackR.Lists;

namespace CrackR.Tests
{
    [TestClass]
    public class ListsTests
    {
        [TestMethod]
        public void RemoveListDuplicatesTest()
        {
            var list = GetUnorderedList();
            list.RemoveDuplicates();
            var iterator = list;
            Assert.AreEqual(7, iterator.Value);
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                    continue;
                iterator = iterator.Next;
                Assert.AreEqual(i, iterator.Value);
            }
        }

        [TestMethod]
        public void GetKthElementFromTail()
        {
            var list = GetUnorderedList();
            Assert.AreEqual(7, list.GetFromTail(3));
        }

        [TestMethod]
        public void RemoveMiddle()
        {
            var list = GetUnorderedList();
            var removed = list.RemoveMiddle();
            Assert.AreEqual(9, removed);
        }

        [TestMethod]
        public void Sum()
        {
            var a = new Node<int>(7);
            a.Next = new Node<int>(1);
            a.Next.Next = new Node<int>(6);
            var b = new Node<int>(5);
            b.Next = new Node<int>(9);
            b.Next.Next = new Node<int>(2);
            var r = a.Sum(b);
            Assert.AreEqual(2, r.Value);
            Assert.AreEqual(1, r.Next.Value);
            Assert.AreEqual(9, r.Next.Next.Value);
        }

        [TestMethod]
        public void SumInOrder()
        {
            var a = new Node<int>(6);
            a.Next = new Node<int>(1);
            a.Next.Next = new Node<int>(7);
            var b = new Node<int>(2);
            b.Next = new Node<int>(9);
            b.Next.Next = new Node<int>(5);
            var r = a.SumInOrder(b);
            Assert.AreEqual(9, r.Value);
            Assert.AreEqual(1, r.Next.Value);
            Assert.AreEqual(2, r.Next.Next.Value);
        }

        [TestMethod]
        public void LoopedListTest()
        {
            var lst = GetLoopedList();
            var result = lst.GetLoop();
            Assert.AreEqual('C', result);
        }

        [TestMethod]
        public void IsPalindrome()
        {
            var palindrome = GetPalindrome();
            Assert.AreEqual(true, palindrome.IsPalindrome());
            var nonPalindrome = GetUnorderedList();
            Assert.AreEqual(false, nonPalindrome.IsPalindrome());
        }

        private Node<int> GetUnorderedList()
        {
            var list = new Node<int>(7);
            var iterator = list;
            for (int i = 0; i < 10; i++)
            {
                iterator.Next = new Node<int>(i);
                iterator = iterator.Next;
            }
            for (int i = 0; i < 10; i++)
            {
                iterator.Next = new Node<int>(i);
                iterator = iterator.Next;
            }
            return list;
        }

        private Node<char> GetLoopedList()
        {
            var lst = new Node<char>('A');
            var head = lst;
            lst.Next = new Node<char>('B');
            lst = lst.Next;
            var c = new Node<char>('C');
            lst.Next = c;
            lst = lst.Next;
            lst.Next = new Node<char>('D');
            lst = lst.Next;
            lst.Next = new Node<char>('E',c);
            return head;
        }

        private Node<int> GetPalindrome()
        {
            var list = new Node<int>(0);
            var head = list;
            list.Next = new Node<int>(1);
            list = list.Next;
            list.Next = new Node<int>(2);
            list = list.Next;
            list.Next = new Node<int>(1);
            list = list.Next;
            list.Next = new Node<int>(0);
            return head;
        }
    }
}
