using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackR.TreesAndGraphs
{
    public class BinaryTree<T> where T:IComparable<T>
    {
        public Node<T> Root { get; set; }

        public void Add(T value)
        {
            if(Root == null)
                Root = new Node<T>(value);
            else
                InsertClosest(value, Root);
            CalculateHeight(Root);
        }

        public Node<T> Search(T value, Node<T> root = null)
        {
            if (root == null)
                root = Root;
            if (root.Value.CompareTo(value) == 0)
            {
                return root;
            }
            else
            {
                if (root.Value.CompareTo(value) < 0)
                {
                    if (root.Left == null)
                        return null;
                    return Search(value, root.Left);
                }
                else
                {
                    if (root.Right == null)
                        return null;
                    return Search(value, root.Right);
                }
            }
        }

        private Node<T> InsertClosest(T value, Node<T> root)
        {
            while (true)
            {
                if (root.Value.CompareTo(value) < 0)
                {
                    if (root.Left == null)
                    {
                        root.Left = new Node<T>(value);
                        return root.Left;
                    }
                    root = root.Left;
                }
                else
                {
                    if (root.Right == null)
                    {
                        root.Right = new Node<T>(value);
                        return root.Right;
                    }
                    root = root.Right;
                }
            }
        }

        private int CalculateHeight(Node<T> root)
        {
            if (root == null)
                return 0;
            else
            {
                root.Height = Math.Max(CalculateHeight(root.Left), CalculateHeight(root.Right)) +1;
                return root.Height;
            }
        }

        public bool IsBalanced()
        {
            if (Root == null || (Root.Left == Root.Right && Root.Right == null))
                return true;
            if (Root.Left == null || Root.Right == null)
                return false;
            return Math.Abs(Root.Left.Height - Root.Right.Height) <= 1;
        }
    }

    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        } 
        public T Value { get; set; }
        public int Height { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; } 
    }
}
