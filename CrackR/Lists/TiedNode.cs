using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.Lists
{
    public class TiedNode<T>: Node<T>
    {
        public TiedNode(T value) : base(value)
        {

        }

        public TiedNode<T> Previous { get; set; }
    }
}
