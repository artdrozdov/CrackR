using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.StacksAndQueues
{
    public class SortedStack<T> where T:IComparable<T>
    {
        private Stack<T> _sorted { get; set; }
        private Stack<T> _tempStorage { get; set; }

        public int Count
        {
            get { return _sorted.Count; }
        }

        public SortedStack()
        {
            _sorted = new Stack<T>();
            _tempStorage = new Stack<T>();
        } 

        public void Push(T value)
        {
                while (_sorted.Count > 0 && _sorted.Peek().CompareTo(value) < 0)
                {
                    _tempStorage.Push(_sorted.Pop());
                }
                _sorted.Push(value);
                while (_tempStorage.Count > 0)
                {
                    _sorted.Push(_tempStorage.Pop());
                }
        }

        public T Pop()
        {
            return _sorted.Pop();
        }

        public T Peek()
        {
            return _sorted.Peek();
        }
    }
}
