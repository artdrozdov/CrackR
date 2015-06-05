using System.Collections.Generic;

namespace CrackR.Lists
{
    public static class NodeExtensions
    {
        public static void RemoveDuplicates<T>(this Node<T> head)
        {
                var slowIterator = head;
                while (slowIterator != null && slowIterator.Next != null)
                {
                    var runningIterator = slowIterator.Next;
                    while (runningIterator != null && runningIterator.Next != null)
                    {
                        if (slowIterator.Value.Equals(runningIterator.Next.Value))
                        {
                            runningIterator.Next = runningIterator.Next.Next;
                        }
                        runningIterator = runningIterator.Next;
                    }
                    slowIterator = slowIterator.Next;
                }
        }

        //returns k-th element from tail
        public static T GetFromTail<T>(this Node<T> head, int k)
        {
            var slow = head;
            var fast = head;
            for (int i = 1; i < k; i++)
            {
                fast = fast.Next;
            }
            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            return slow.Value;
        }

        public static T RemoveMiddle<T>(this Node<T> head)
        {
            var slow = head;
            var parent = head;
            var fast = head;
            while (fast.Next != null)
            {
                parent = slow;
                slow = slow.Next;
                fast = fast.Next;
                if (fast.Next == null) break;
                fast = fast.Next;
            }
            parent.Next = slow.Next;
            return slow.Value;
        }

        public static Node<int> Divide(this Node<int> list, int x)
        {
            Node<int> lower = null, head = null, middle = null, greater = null;
            var iterator = list;
            while (iterator != null)
            {
                if (iterator.Value < x)
                {
                    if (lower == null)
                    {
                        lower = new Node<int>(iterator.Value);
                        head = lower;
                    }
                    else {
                        lower.Next = new Node<int>(iterator.Value);
                        lower = lower.Next;
                    }
                }
                else
                {
                    if (greater == null)
                    {
                        greater = new Node<int>(iterator.Value);
                        middle = greater;
                    }
                    else
                    {
                        greater.Next = new Node<int>(iterator.Value);
                        greater = greater.Next;
                    }
                }
                iterator = iterator.Next;
            }
            lower.Next = middle;
            return head;
        }

        public static Node<int> Sum(this Node<int> a, Node<int> b)
        {
            Node<int> result = null, head = null;
            var pa = a;
            var pb = b;
            int addition = 0;
            while (pa != null || pb != null)
            {
                int i = 0;
                if (pa != null)
                {
                    i += pa.Value;
                    pa = pa.Next;
                }
                if (pb != null)
                {
                    i += pb.Value;
                    pb = pb.Next;
                }
                int store = i + addition;
                if (i > 9)
                {
                    store = i % 10 + addition;
                    addition = i / 10;
                }
                else
                {
                    addition = 0;
                }
                if (result == null)
                {
                    result = new Node<int>(store);
                    head = result;
                }
                else
                {
                    result.Next = new Node<int>(store);
                    result = result.Next;
                }
            }
            return head;
        }

        public static Node<int> SumInOrder(this Node<int> a, Node<int> b){
            //Node<int> result = null, head = null;
            var tmp = new Node<int>(a.Value + b.Value);
            var tmpHead = tmp;
            var iteratorA = a.Next;
            var iteratorB = b.Next;
            while (iteratorA != null && iteratorB != null)
            {
                tmp.Next = new Node<int>(iteratorA.Value + iteratorB.Value);
                tmp = tmp.Next;
                iteratorA = iteratorA.Next;
                iteratorB = iteratorB.Next;
            }
            
            int addition = 0;
            var previous = tmp;
            do
            {
                tmp = previous;
                int i = tmp.Value + addition;
                if (i > 9)
                {
                    tmp.Value = i % 10;
                    addition = i / 10;
                }
                else
                {
                    tmp.Value = i;
                    addition = 0;
                }
                previous = tmpHead;
                while (previous != tmp && previous.Next != tmp)
                {
                    previous = previous.Next;
                }
            } while (tmp != tmpHead);
            return tmp;
        }

        public static T GetLoop<T>(this Node<T> list)
        {
            var slow = list;
            var fast = list;
            do
            {
                slow = slow.Next;
                fast = fast.Next;
                fast = fast.Next;
            } while (slow != fast);
            slow = list;
            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
                //fast = fast.Next;
            }
            return slow.Value;
        }

        public static bool IsPalindrome<T>(this Node<T> list)
        {
            var slow = list;
            var fast = list;
            var stack = new Stack<T>();
            while (fast != null && fast.Next != null)
            {
                stack.Push(slow.Value);
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            //pass middle element
            if (fast != null)
            {
                slow = slow.Next;
            }
            while (slow != null)
            {
                if (!slow.Value.Equals(stack.Pop()))
                {
                    return false;
                }
                slow = slow.Next;
            }
            return true;
        }
    }
}
