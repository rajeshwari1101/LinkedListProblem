using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello welcome to Linked List Problem");
            Program program = new Program();
            program.LinkedListCall();
            Console.ReadLine();
        }

        public void LinkedListCall()
        {
            LinkedList customLinkedList = new LinkedList();
            customLinkedList.AddLastNode(56);
            customLinkedList.AddLastNode(30);
            customLinkedList.AddLastNode(70);
            customLinkedList.DisplayLinkedList();
            Console.WriteLine("-------------------------");
            int node = customLinkedList.SearchNode(30);
            customLinkedList.InsertAtParticularPosition(node + 1, 40);
            customLinkedList.DisplayLinkedList();
        }
    }
}