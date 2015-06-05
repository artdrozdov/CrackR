using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackR.Lists;

namespace CrackR.StacksAndQueues
{
    public class MinStack<T> where T:IComparable<T>
    {
        private Node<T> _min { get; set; }
        private Node<T> _heap { get; set; }

        public void Push(T value)
        {
            if (_heap != null)
            {
                var newNode = new Node<T>(value);
                newNode.Next = _heap;
                _heap = newNode;
                if (_heap.Value.CompareTo(_min.Value) <= 0)
                {
                    var node = new Node<T>(_heap.Value);
                    node.Next = _min;
                    _min = node;
                }
            }
            else
            {
                _heap = new Node<T>(value);
                
                _min = new Node<T>(value);
            }
        }

        public T Pop()
        {
            if (_heap == null)
            {
                throw new InvalidOperationException();
            }
            var result = _heap.Value;
            _heap = _heap.Next;
            if (result.CompareTo(_min.Value) == 0)
            {
                _min = _min.Next;
            }
            return result;
        }

        public T Min()
        {
            if(_min == null)
                throw new InvalidOperationException();
            return _min.Value;
        }
    }
}
