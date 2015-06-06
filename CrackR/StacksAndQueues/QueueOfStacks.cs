using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.StacksAndQueues
{
    public class QueueOfStacks<T>
    {
        private Stack<T> oldData { get; set; }
        private Stack<T> newData { get; set; }

        public QueueOfStacks()
        {
            oldData = new Stack<T>();
            newData = new Stack<T>();
        }

        public void Push(T value)
        {
            newData.Push(value);
        }

        public T Peek()
        {
            if (oldData.Count == 0)
            {
                while (newData.Count > 0)
                    oldData.Push(newData.Pop());
            }
            return oldData.Pop();
        }
    }
}
