using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class Node
    {
        //Instance var.
        public int data;
        public Node next;
        //Constructor to create a Node with data and next pointer.
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class SortedNode<T>
    {
        public T data;
        public SortedNode<T> next;
        /// <summary>
        /// Initializes a new instance of the <see cref="SortedNode{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public SortedNode(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}

