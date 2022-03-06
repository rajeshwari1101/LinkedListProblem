﻿using System;
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
            //  program.LinkedListCall();
            SortedLinkedListView();
            Console.ReadLine();
        }
        /// <summary>
        /// view the linked list operations.
        /// </summary>
        public void LinkedListCall()
        {
            LinkedList customLinkedList = new LinkedList();
            Console.WriteLine("<--------Linked List--------->");
            customLinkedList.AddLastNode(56);
            customLinkedList.AddLastNode(30);
            customLinkedList.AddLastNode(40);
            customLinkedList.AddLastNode(70);
            customLinkedList.DisplayLinkedList();
            Console.WriteLine("<------------------------->");
            int key = customLinkedList.SearchNode(40);
            customLinkedList.DeleteAtParticularPosition(key);
            customLinkedList.DisplayLinkedList();
            customLinkedList.Size();
        }
        /// view the linked list Sorted operations

        public static void SortedLinkedListView()
        {
            SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
            Console.WriteLine("<----SortedLinkedList---->");
            sortedLinkedList.Add(new SortedNode<int>(70));
            sortedLinkedList.Add(new SortedNode<int>(40));
            sortedLinkedList.Add(new SortedNode<int>(30));
            sortedLinkedList.Add(new SortedNode<int>(56));
            Console.WriteLine("LinkedList before sorting");
            sortedLinkedList.Display();
            sortedLinkedList.SortedList();
            Console.WriteLine("LinkedList after sorting");
            sortedLinkedList.Display();
        }
    }
}