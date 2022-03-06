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
            customLinkedList.AddLastNode(76);
            Console.WriteLine("nodes inserted");
            customLinkedList.DisplayLinkedList();

            customLinkedList.AddFirstNode(70);
            customLinkedList.AddFirstNode(30);
            customLinkedList.AddFirstNode(56);
            customLinkedList.DisplayLinkedList();
        }


    }
}