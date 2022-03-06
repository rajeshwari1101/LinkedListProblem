﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
        public Node head;

        //Method to Add Node at Last in Linked List
        public void AddLastNode(int data)
        {
            Node node = new Node(data);

            //condition to Check head and add first Node.
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                //Temp Node to work.
                Node temp = head;

                //Loop to check next pointer in Node.
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        //Display Method
        public void DisplayLinkedList()
        {
            Console.WriteLine("Display nodes of Linked List");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Nodes are : " + temp.data);
                    temp = temp.next;
                }
            }
        }
        //Method to Add Node at First in Linked List
        public void AddFirstNode(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} : Nodes inserted in Linked list ", newNode.data);
        }
    }
}
