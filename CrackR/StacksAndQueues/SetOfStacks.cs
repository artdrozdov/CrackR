using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.StacksAndQueues
{
    public class SetOfStacks<T>
    {
        private Stack<T>[] _table { get; set; }
        private int Size = 4;
        private int CurrentStack { get; set; }
        private int StackLimit { get; set; }

        public SetOfStacks()
        {
            _table = new Stack<T>[0];
            StackLimit = 10;
        }

        public SetOfStacks(int size):this()
        {
            Size = size;
        }

        public SetOfStacks(int size, int stackLimit):this(size)
        {
            stackLimit = stackLimit;
        }

        public void Push(T value)
        {
            if(_table.Length == 0)
                ExpandTable();

            if (CurrentStack == _table.Length)
                ExpandTable();

            if (_table[CurrentStack] == null)
                _table[CurrentStack] = new Stack<T>();

            if (_table[CurrentStack].Count == StackLimit)
            {
                CurrentStack++;
                Push(value);
            } else
                _table[CurrentStack].Push(value);
            
        }

        public T Pop()
        {
            if (_table[CurrentStack].Count == 0)
                CurrentStack--;
            if (CurrentStack >= 0)
                return _table[CurrentStack].Pop();
            throw new InvalidOperationException();
        }

        public T PopAt(int stackIndex)
        {
            if (stackIndex < _table.Length && _table[stackIndex] != null)
            {
                CurrentStack = stackIndex;
                return _table[stackIndex].Pop();
            }
            throw new InvalidOperationException();
        }

        private void ExpandTable()
        {
            if(_table.Length != 0)
                Size *= 2;
            var newTable = new Stack<T>[Size];
            for (int i = 0; i < _table.Length; i++)
            {
                newTable[i] = _table[i];
            }
            _table = newTable;
        }
    }
}
